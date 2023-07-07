    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ClassWithParameters
    {
        public class ListOfUsers
        {
            private readonly List<User> users;

            public ListOfUsers(List<User> list = null)
            {
                if (list != null)
                    this.users = list;
                else
                {
                    this.users = new List<User>();
                    createSampleUsersList();
                }
            }
            public async void addUser(string Name,int Age, string Adress)
            {
                await Task.Run(() => { users.Add(new User(name: Name, age: Age, address: Adress)); });
           
            }
            public  async Task<List<User>> GetUsersAsync() {
                Task.Delay(0);
                return users; }

            private void createSampleUsersList()
            {
        addUser("Adam Smith", 25, "ul. Klonowa 1")          ;
        addUser("Barbara Johnson", 32, "ul. Lipowa 5")              ;
        addUser("Catherine Williams", 45, "ul. Dębowa 10")          ;
        addUser("David Brown", 38, "ul. Sosnowa 15")                ;
        addUser("Emily Anderson", 27, "ul. Akacjowa 20")            ;
        addUser("Frank Taylor", 31, "ul. Brzozowa 25")              ;
        addUser("Grace Davis", 29, "ul. Topolowa 30")               ;
        addUser("Henry Wilson", 42, "ul. Bukowa 35")                ;
        addUser("Isabella Martinez", 36, "ul. Jaworowa 40")         ;
        addUser("James Anderson", 33, "ul. Modrzewiowa 45")         ;
        addUser("Karen Moore", 48, "ul. Olchowa 50")                ;
        addUser("Liam Taylor", 26, "ul. Świerkowa 55")              ;
        addUser("Mia Johnson", 34, "ul. Jodłowa 60")                ;
        addUser("Noah Davis", 28, "ul. Klonowa 65")                 ;
        addUser("Olivia Smith", 41, "ul. Lipowa 70")                ;
        addUser("Patrick Wilson", 37, "ul. Dębowa 75")              ;
        addUser("Quinn Martinez", 30, "ul. Sosnowa 80")             ;
        addUser("Rachel Brown", 43, "ul. Akacjowa 85")              ;
        addUser("Samuel Anderson", 35, "ul. Brzozowa 90")           ;
        addUser("Taylor Williams", 39, "ul. Topolowa 95")           ;
        addUser("Ursula Davis", 46, "ul. Bukowa 100")               ;
        addUser("Victor Smith", 32, "ul. Jaworowa 105")             ;
        addUser("Wendy Johnson", 44, "ul. Modrzewiowa 110")         ;
        addUser("Xavier Taylor", 29, "ul. Olchowa 115")             ;
        addUser("Yvonne Moore", 38, "ul. Świerkowa 120")            ;
        addUser("Zachary Wilson", 31, "ul. Jodłowa 125")            ;
        addUser("Alice Martinez", 47, "ul. Klonowa 130")            ;
        addUser("Benjamin Anderson", 25, "ul. Lipowa 135")          ;
        addUser("Charlotte Davis", 33, "ul. Dębowa 140")            ;
        addUser("Daniel Brown", 45, "ul. Sosnowa 145")              ;
        addUser("Emma Smith", 27, "ul. Akacjowa 150")               ;
        addUser("Finn Johnson", 42, "ul. Brzozowa 155")             ;
        addUser("Grace Wilson", 36, "ul. Topolowa 160")             ;
        addUser("Henry Davis", 34, "ul. Bukowa 165")                ;
        addUser("Isabella Taylor", 48, "ul. Jaworowa 170")          ;
        addUser("Jacob Martinez", 26, "ul. Modrzewiowa 175")        ;
        addUser("Katherine Anderson", 43, "ul. Olchowa 180")        ;
        addUser("Liam Brown", 35, "ul. Świerkowa 185")              ;
        addUser("Mia Smith", 39, "ul. Jodłowa 190")                 ;
        addUser("Noah Davis", 46, "ul. Klonowa 195")                ;
        addUser("Olivia Wilson", 32, "ul. Lipowa 200")              ;
        addUser("Patrick Davis", 44, "ul. Dębowa 205")              ;
        addUser("Quinn Smith", 29, "ul. Sosnowa 210")               ;
        addUser("Rachel Johnson", 37, "ul. Akacjowa 215")           ;
        addUser("Samuel Brown", 41, "ul. Brzozowa 220")             ;
        addUser("Taylor Martinez", 30, "ul. Topolowa 225")          ;
        addUser("Ursula Anderson", 42, "ul. Bukowa 230")            ;
        addUser("Victor Davis", 35, "ul. Jaworowa 235")             ;
        addUser("Wendy Wilson", 47, "ul. Modrzewiowa 240")          ;
        addUser("Xavier Moore", 31, "ul. Olchowa 245")              ;
        addUser("Yvonne Taylor", 43, "ul. Świerkowa 250")           ;
        addUser("Zachary Johnson", 33, "ul. Jodłowa 255")           ;
        addUser("Abigail Smith", 45, "ul. Klonowa 260")             ;
        addUser("Benjamin Brown", 28, "ul. Lipowa 265")             ;
        addUser("Charlotte Davis", 46, "ul. Dębowa 270")            ;
        addUser("Daniel Wilson", 34, "ul. Sosnowa 275")             ;
        addUser("Emily Anderson", 49, "ul. Akacjowa 280")           ;
        addUser("Finn Moore", 32, "ul. Brzozowa 285")               ;
        addUser("Grace Taylor", 44, "ul. Topolowa 290")             ;
        addUser("Henry Johnson", 36, "ul. Bukowa 295")              ;
        addUser("Isabella Davis", 50, "ul. Jaworowa 300")           ;
        addUser("Jacob Brown", 27, "ul. Modrzewiowa 305")           ;
        addUser("Katherine Smith", 47, "ul. Olchowa 310")           ;
        addUser("Liam Wilson", 31, "ul. Świerkowa 315")             ;
        addUser("Mia Martinez", 45, "ul. Jodłowa 320")              ;
        addUser("Noah Anderson", 33, "ul. Klonowa 325")             ;
        addUser("Olivia Davis", 49, "ul. Lipowa 330")               ;
        addUser("Patrick Wilson", 35, "ul. Dębowa 335")             ;
        addUser("Quinn Johnson", 50, "ul. Sosnowa 340")             ;
        addUser("Rachel Brown", 32, "ul. Akacjowa 345")             ;
        addUser("Samuel Taylor", 46, "ul. Brzozowa 350")            ;
        addUser("Taylor Moore", 34, "ul. Topolowa 355")             ;
        addUser("Ursula Smith", 51, "ul. Bukowa 360")               ;
        addUser("Victor Davis", 37, "ul. Jaworowa 365")             ;
        addUser("Wendy Wilson", 48, "ul. Modrzewiowa 370")          ;
        addUser("Xavier Martinez", 33, "ul. Olchowa 375")           ;
        addUser("Yvonne Anderson", 47, "ul. Świerkowa 380")         ;
        addUser("Zachary Brown", 35, "ul. Jodłowa 385")             ;
        addUser("Alice Taylor", 52, "ul. Klonowa 390")              ;
        addUser("Benjamin Moore", 29, "ul. Lipowa 395")             ;
        addUser("Charlotte Smith", 46, "ul. Dębowa 400")            ;
        addUser("Daniel Davis", 36, "ul. Sosnowa 405")              ;
        addUser("Emma Wilson", 50, "ul. Akacjowa 410")              ;
        addUser("Finn Johnson", 34, "ul. Brzozowa 415")             ;
        addUser("Grace Brown", 47, "ul. Topolowa 420")              ;
        addUser("Henry Anderson", 31, "ul. Bukowa 425")             ;
        addUser("Isabella Taylor", 51, "ul. Jaworowa 430")          ;
        addUser("Jacob Martinez", 38, "ul. Modrzewiowa 435")        ;
        addUser("Katherine Davis", 48, "ul. Olchowa 440")           ;
        addUser("Liam Wilson", 32, "ul. Świerkowa 445")             ;
        addUser("Mia Anderson", 52, "ul. Jodłowa 450")              ;
        addUser("Noah Moore", 35, "ul. Klonowa 455")                ;
        addUser("Olivia Smith", 49, "ul. Lipowa 460")               ;
        addUser("Patrick Johnson", 33, "ul. Dębowa 465")            ;
        addUser("Quinn Davis", 51, "ul. Sosnowa 470")               ;
        addUser("Rachel Wilson", 37, "ul. Akacjowa 475")            ;
        addUser("Samuel Brown", 53, "ul. Brzozowa 480")             ;
        addUser("Taylor Martinez", 34, "ul. Topolowa 485")          ;
        addUser("Ursula Anderson", 50, "ul. Bukowa 490")            ;
        addUser("Victor Davis", 38, "ul. Jaworowa 495")             ;
        addUser("Wendy Wilson", 54, "ul. Modrzewiowa 500")          ;
        addUser("Xavier Moore", 35, "ul. Olchowa 505")              ;
        addUser("Yvonne Taylor", 51, "ul. Świerkowa 510")           ;
        addUser("Zachary Johnson", 39, "ul. Jodłowa 515")           ;
        addUser("Abigail Smith", 53, "ul. Klonowa 520")             ;
        addUser("Benjamin Brown", 32, "ul. Lipowa 525")             ;
        addUser("Charlotte Davis", 52, "ul. Dębowa 530")            ;
        addUser("Daniel Wilson", 36, "ul. Sosnowa 535")             ;
        addUser("Emily Anderson", 54, "ul. Akacjowa 540")           ;
        addUser("Finn Moore", 37, "ul. Brzozowa 545")               ;
        addUser("Grace Taylor", 53, "ul. Topolowa 550")             ;
        addUser("Henry Johnson", 34, "ul. Bukowa 555")              ;
        addUser("Isabella Davis", 55, "ul. Jaworowa 560")           ;
        addUser("Jacob Brown", 39, "ul. Modrzewiowa 565")           ;
        addUser("Katherine Smith", 54, "ul. Olchowa 570")           ;
        addUser("Liam Wilson", 35, "ul. Świerkowa 575")             ;
        addUser("Mia Martinez", 55, "ul. Jodłowa 580")              ;
        addUser("Noah Anderson", 36, "ul. Klonowa 585")             ;
        addUser("Olivia Davis", 56, "ul. Lipowa 590")               ;
        addUser("Patrick Wilson", 33, "ul. Dębowa 595")             ;
        addUser("Quinn Johnson", 55, "ul. Sosnowa 600")             ;
        addUser("Rachel Brown", 37, "ul. Akacjowa 605")             ;
        addUser("Samuel Taylor", 57, "ul. Brzozowa 610")            ;
        addUser("Taylor Moore", 35, "ul. Topolowa 615")             ;
        addUser("Ursula Smith", 56, "ul. Bukowa 620")               ;
        addUser("Victor Davis", 38, "ul. Jaworowa 625")             ;
        addUser("Wendy Wilson", 58, "ul. Modrzewiowa 630")          ;
        addUser("Xavier Martinez", 36, "ul. Olchowa 635")           ;
        addUser("Yvonne Anderson", 57, "ul. Świerkowa 640")         ;
        addUser("Zachary Brown", 39, "ul. Jodłowa 645")             ;
        addUser("Alice Taylor", 59, "ul. Klonowa 650")              ;
        addUser("Benjamin Moore", 37, "ul. Lipowa 655")             ;
        addUser("Charlotte Smith", 58, "ul. Dębowa 660")            ;
        addUser("Daniel Davis", 35, "ul. Sosnowa 665")              ;
        addUser("Emma Wilson", 60, "ul. Akacjowa 670")              ;
        addUser("Finn Johnson", 38, "ul. Brzozowa 675")             ;
        addUser("Grace Brown", 57, "ul. Topolowa 680")              ;
        addUser("Henry Anderson", 36, "ul. Bukowa 685")             ;
        addUser("Isabella Taylor", 61, "ul. Jaworowa 690")          ;
        addUser("Jacob Martinez", 40, "ul. Modrzewiowa 695")        ;
        addUser("Katherine Davis", 59, "ul. Olchowa 700")           ;
        addUser("Liam Wilson", 37, "ul. Świerkowa 705")             ;
        addUser("Mia Anderson", 61, "ul. Jodłowa 710")              ;
        addUser("Noah Moore", 38, "ul. Klonowa 715")                ;
        addUser("Olivia Smith", 60, "ul. Lipowa 720")               ;
        addUser("Patrick Johnson", 36, "ul. Dębowa 725")            ;
        addUser("Quinn Davis", 62, "ul. Sosnowa 730")               ;
        addUser("Rachel Wilson", 39, "ul. Akacjowa 735")            ;
        addUser("Samuel Brown", 63, "ul. Brzozowa 740")             ;
        addUser("Taylor Martinez", 37, "ul. Topolowa 745")          ;
        addUser("Ursula Anderson", 61, "ul. Bukowa 750")            ;
        addUser("Victor Davis", 40, "ul. Jaworowa 755")             ;
        addUser("Wendy Wilson", 64, "ul. Modrzewiowa 760")          ;
        addUser("Xavier Moore", 38, "ul. Olchowa 765")              ;
        addUser("Yvonne Taylor", 62, "ul. Świerkowa 770")           ;
        addUser("Zachary Johnson", 41, "ul. Jodłowa 775")           ;
        addUser("Abigail Smith", 63, "ul. Klonowa 780")             ;
        addUser("Benjamin Brown", 37, "ul. Lipowa 785")             ;
        addUser("Charlotte Davis", 62, "ul. Dębowa 790")            ;
        addUser("Daniel Wilson", 39, "ul. Sosnowa 795")             ;
        addUser("Emily Anderson", 65, "ul. Akacjowa 800")           ;
        addUser("Finn Moore", 40, "ul. Brzozowa 805")               ;
        addUser("Grace Taylor", 64, "ul. Topolowa 810")             ;
        addUser("Henry Johnson", 37, "ul. Bukowa 815")              ;
        addUser("Isabella Davis", 66, "ul. Jaworowa 820")           ;
        addUser("Jacob Brown", 41, "ul. Modrzewiowa 825")           ;
        addUser("Katherine Smith", 65, "ul. Olchowa 830")           ;
        addUser("Liam Wilson", 39, "ul. Świerkowa 835")             ;
        addUser("Mia Martinez", 67, "ul. Jodłowa 840")              ;
        addUser("Noah Anderson", 40, "ul. Klonowa 845")             ;
        addUser("Olivia Davis", 66, "ul. Lipowa 850")               ;
        addUser("Patrick Wilson", 38, "ul. Dębowa 855")             ;
        addUser("Quinn Johnson", 68, "ul. Sosnowa 860")             ;
        addUser("Rachel Brown", 41, "ul. Akacjowa 865")             ;
        addUser("Samuel Taylor", 67, "ul. Brzozowa 870")            ;
        addUser("Taylor Moore", 39, "ul. Topolowa 875")             ;
        addUser("Ursula Smith", 69, "ul. Bukowa 880")               ;
        addUser("Victor Davis", 42, "ul. Jaworowa 885")             ;
        addUser("Wendy Wilson", 68, "ul. Modrzewiowa 890")          ;
        addUser("Xavier Moore", 40, "ul. Olchowa 895")              ;
        addUser("Yvonne Taylor", 70, "ul. Świerkowa 900")           ;
        addUser("Zachary Johnson", 43, "ul. Jodłowa 905")           ;
        addUser("Alice Smith", 69, "ul. Klonowa 910")               ;
        addUser("Benjamin Brown", 41, "ul. Lipowa 915")             ;
        addUser("Charlotte Davis", 70, "ul. Dębowa 920")            ;
        addUser("Daniel Wilson", 40, "ul. Sosnowa 925")             ;
        addUser("Emma Anderson", 71, "ul. Akacjowa 930")            ;
        addUser("Finn Moore", 42, "ul. Brzozowa 935")               ;
        addUser("Grace Taylor", 70, "ul. Topolowa 940")             ;
        addUser("Henry Johnson", 41, "ul. Bukowa 945")              ;
        addUser("Isabella Davis", 72, "ul. Jaworowa 950")           ;
        addUser("Jacob Brown", 43, "ul. Modrzewiowa 955")           ;
        addUser("Katherine Smith", 71, "ul. Olchowa 960")           ;
        addUser("Liam Wilson", 42, "ul. Świerkowa 965")             ;
        addUser("Mia Martinez", 73, "ul. Jodłowa 970")              ;
        addUser("Noah Anderson", 43, "ul. Klonowa 975")             ;
        addUser("Olivia Davis", 72, "ul. Lipowa 980")               ;
        addUser("Patrick Wilson", 41, "ul. Dębowa 985")             ;
        addUser("Quinn Johnson", 74, "ul. Sosnowa 990")             ;
                addUser("Rachel Brown", 42, "ul. Akacjowa 995");
            }


        }
    }
