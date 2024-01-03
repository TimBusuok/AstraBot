class TelegramBot{
    string token;
    HttpClient hc = new HttpClient();
    Thread thread = new Thread(Planet);
    

    public TelegramBot(string token){
        this.token = token;
        hc = new HttpClient();
        hc.BaseAddress = new Uri($"https://api.telegram.org/bot{token}/");
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
            content = Planet();
            msg = content;
            return msg;
            
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

    public string Planet(){
        string qweston = "О какой планете вы хотите получить данные?:\nМеркурий\nВенера\nЗемля\nМарс\nЮптер\nСатурн\nУран\nНептун";
        string planet = "";
        string content = string.Format("Данные о планете {0} - получены", planet);
        switch(qweston){
            case "/mercure":
            
        }
    }
}