import telebot
import settings
from telebot import types
import sqlite3 as sq

bot = telebot.TeleBot(settings.API_KEY)

@bot.message_handler(commands = ['start'])
def start (message):
    mess = f'Здравствуй, {(message.from_user.first_name)}, Бот создан для получения информации из базы данных, для справки по командам напиши /help'
    bot.send_message(message.chat.id, mess)

@bot.message_handler(commands = ['help'])
def help (message):
    mess = "/View - для просмотра данных таблицы \n/Git для получения ссылки на проект \n/Add для чего то еще"
    bot.send_message(message.chat.id, mess)

@bot.message_handler(commands = ['View'])
def GetTable(message):
    table = bot.send_message(message.chat.id, 'Вы зашли в блок просмотра, Укажите Таблицу')
    bot.register_next_step_handler(table, GetTableInfo)


def GetTableInfo (message):

            if(message.text == 'Задачи'):

                with sq.connect("Diplom/My.db") as con:
                    cur = con.cursor()
                    res = 'ID, Инфо, Дата, Сотрудник, Приоритет, тип задачи\n'
                    stroke = 'select * from Tasks'
                    cur.execute(stroke)

                    for result in cur:
                        res += ''.join(str(x) + ", " for x in result) + "\n"
                    bot.send_message(message.chat.id, res)

            elif(message.text == "Сотрудники"):
                with sq.connect("Diplom/My.db") as con:
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
    bot.send_message(message.chat.id,"Кабан",reply_markup=markup)

bot.polling(none_stop=True)