class TelegramBot{
    string token;
    HttpClient hc = new HttpClient();
    string planet = "";
        int R = 0;
        int D = 0;
        int S = 0;
        int S1 = 0;
        long population = 0;
        int speed = 0;
    

    

    public TelegramBot(string token){
        this.token = token;
        hc = new HttpClient();
        hc.BaseAddress = new Uri($"https://api.telegram.org/bot{token}/");
        string planet = "";
        int R = 0;
        int D = 0;
        int S = 0;
        int S1 = 0;
        long population = 0;
        int speed = 0;
        string infoPlanet = string.Format($"Данные о планете {0} - получены\nРадиус = {1}\nДиаметр = {2}\nРасстояние до Солнца = {3}\nРасстояние до Земли = {4}\nПопуляция = {5}\nСкорость планеты = {6}", planet,R,D,S,S1,population,speed);
    }
    

    public string GetAnswer(string msg){
        switch(msg){
            case "/start":
            string content = "Приветствуем!\nИнформация о спутнике предоставлена в разделе /info";
            msg = content;
            return msg;
            case "/info":
            content = "Этот бот был создан ради того чтобы вам помочь в узновании космоса 🌌\nНаши функции:\nПодробности о всех известных планетах🪐(/planet);\nКакой праздник сегодня🎉(/party);\nКакие Знаки Зодиака существуют(/zz)";
            msg = content;
            return msg;
            case "/stop":
            content = "Досвидание! Приятно с вами работать))😊";
            msg = content;
            return msg;
            case "/party":
            content = CheckDay();
            msg = content;
            return msg;
            case "/planet":
            string qweston = $"О какой планете вы хотите получить данные?:\nМеркурий(/mercure)\nВенера(/venera)\nЗемля(/earth)\nМарс(/mars)\nЮптер(/jupiter)\nСатурн(/saturn)\nУран(/uran)\nНептун(/neptun)";
            msg = qweston;
            return msg;
            case "/mercure":
            planet = "Меркурий";
            R = R + 2440;
            D = D + 4880;
            S = S + 58000000;
            S1 = S1 + 91600000;
            speed = speed + 48;
            string infoPlanet = $"Данные о планете -{planet}- получены:\nРадиус = {R}км\nДиаметр = {D}км\nРасстояние до Солнца = {S}км\nРасстояние до Земли = {S1}км\nПопуляция = пару вездеходов))\nСкорость планеты = {speed}км/с";
            msg = infoPlanet;
            return msg;
            case "/venera":
            planet = "Венера";
            R = R + 6052;
            D = D +12104;
            S = S + 108000000;
            S1 = S1 + 41400000;
            speed = speed + 35;
            infoPlanet = $"Данные о планете -{planet}- получены:\nРадиус = {R}км\nДиаметр = {D}км\nРасстояние до Солнца = {S}км\nРасстояние до Земли = {S1}км\nПопуляция = пару вездеходов))\nСкорость планеты = {speed}км/с";
            msg = infoPlanet;
            return msg;
            case "/earth":
            planet = "Земля";
            R = R + 6371;
            D = D + 12742;
            S = S + 150000000;
            population = population + 8000000000;
            speed = speed + 35;
            infoPlanet = $"Данные о планете -{planet}- получены:\nРадиус = {R}км\nДиаметр = {D}км\nРасстояние до Солнца = {S}км\nРасстояние до Земли = {S1}км\nПопуляция = {population} человек\nСкорость планеты = {speed}км/с";
            msg = infoPlanet;
            return infoPlanet;
            
        }
        return "Неккоректный ввод";
    }

    public string CheckDay(){
        DateTime date = new DateTime();
        string incrementedDateTime = date.AddDays(2).ToString();
        string dataRes = incrementedDateTime.Remove(incrementedDateTime.Length - 13);
        string hollidays = ShowHolidays(date);
        string res = $"Сегодня ({dataRes}) такие праздники🎉🎉:\n{hollidays}";
        return res;
    }
    public string ShowHolidays(DateTime date)
    {
    string incrementedDateTime = date.AddDays(1).ToString();
    string res = incrementedDateTime.Remove(incrementedDateTime.Length - 13);
    string party = "";

    switch (res)
    {
        case "01.01":
        case "02.01":
        case "03.01":
        case "04.01":
        case "05.01":
        case "06.01":
        case "08.01":
            party = "Новогодние праздники⛄🎅";
            break;

        case "07.01":
            party = "Новогодние праздники⛄🎅\nРождество🎄";
            break;

        case "23.02":
            party = "День Защитника Отечества🏋️💪";
            break;

        case "08.03":
            party = "Международный женский день🌹🌹";
            break;

        case "01.05":
            party = "Праздник Весны и Труда🌿👔";
            break;

        case "09.05":
            party = "День Победы🎆🎆";
            break;

        case "04.11":
            party = "День народного единства👨👩👳🧕";
            break;

        case "12.06":
            party = "День России 🇷🇺";
            break;

        default:
            party = "Cегодня праздников нет😔";
            break;
    }

        return party;
    }
   
}
