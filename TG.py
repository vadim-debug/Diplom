import telebot
import settings
from telebot import types
import sqlite3 as sq
bot = telebot.TeleBot(settings.API_KEY)
Info =""
StrCon = "Diplom/bin/Debug/My.db"
@bot.message_handler(commands = ['start'])
def start (message):
    mess = f'Здравствуй, {(message.from_user.first_name)}, Бот создан для получения информации из базы данных, для справки по командам напиши /help'
    bot.send_message(message.chat.id, mess)

@bot.message_handler(commands = ['help'])
def help (message):
    mess = "/View - для просмотра данных таблицы \n/Git для получения ссылки на проект \n/Add для создания записи\n/Delete для удаления записи"
    bot.send_message(message.chat.id, mess)

@bot.message_handler(commands = ['View'])
def GetTable(message):
    table = bot.send_message(message.chat.id, 'Вы зашли в блок просмотра, Укажите Таблицу')
    bot.register_next_step_handler(table, GetTableInfo)

@bot.message_handler(commands=['Delete'])
def DelStroke(message):
    strokeId = bot.send_message(message.chat.id, 'Вы зашли в блок удаления, Укажите номер записи для удаления')
    bot.register_next_step_handler(strokeId, DelTask)


def DelTask(message):
    with sq.connect(StrCon) as con:
        cur = con.cursor()

        stroke = f'DELETE FROM Tasks WHERE id = {message.text};'
        cur.execute(stroke)


def GetTableInfo (message):

            if(message.text == 'Задачи'):

                with sq.connect(StrCon) as con:
                    cur = con.cursor()
                    res = 'ID, Инфо, Дата, Сотрудник, Приоритет, тип задачи\n'
                    stroke = 'select * from Tasks'
                    cur.execute(stroke)

                    for result in cur:
                        res += ''.join(str(x) + ", " for x in result) + "\n"
                    bot.send_message(message.chat.id, res)

            elif(message.text == "Сотрудники"):
                with sq.connect(StrCon) as con:
                    cur = con.cursor()
                    res = 'ID, Имя, роль\n'
                    stroke = 'select * from Users'
                    cur.execute(stroke)

                    for result in cur:
                        res += ''.join(str(x) + ", " for x in result) + "\n"
                    bot.send_message(message.chat.id, res)

@bot.message_handler(commands = ['Git'])
def GetGit(message):
    markup = types.InlineKeyboardMarkup()
    markup.add(types.InlineKeyboardButton("Проект на GitHub", url="https://github.com/vadim-debug/Diplom"))
    bot.send_message(message.chat.id,"Клик",reply_markup=markup)

@bot.message_handler(commands = ['Add'])
def AddTask(message):

    table = bot.send_message(message.chat.id, 'Вы зашли в блок Добавления, укажите полную инормацию о задаче согласно шаблону(ШАБЛОН), если хотите выйти, напишите Выход')
    bot.register_next_step_handler(table, AddTable)

def AddTable(message):
    if(message.text=="Выход"):
        bot.send_message(message.chat.id, 'Вы вышли из добавления')
    else:
        TableInform = message.text
        LInfo = TableInform.split(';')

        with sq.connect(StrCon) as con:
            cur = con.cursor()
            cur.execute('SELECT * FROM Tasks ORDER BY ID DESC LIMIT 1')
            result = cur.fetchone()

            TaskId = result[0]+1
            stroke = f"INSERT INTO Tasks VALUES({TaskId},'{LInfo[0]}','{LInfo[1]}','{LInfo[2]}','{LInfo[3]}','{LInfo[4]}')"

            cur = con.cursor()
            cur.execute(stroke)
            con.commit()

bot.polling(none_stop=True)