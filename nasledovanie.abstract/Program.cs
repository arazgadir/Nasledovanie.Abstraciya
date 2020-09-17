using System;
using System.Security.Cryptography.X509Certificates;

namespace zadacha6
{




    //    1) Создать базовый класс Student, который будет содержать информацию о студенте(фамилия, курс обучения, номер зачетной книги).
    //С помощью механизма наследование реализовать класс Aspirant(аспирант – студент, который готовится к защите кандидатской диссертации). Класс Aspirant есть производным от класса Student.
    //В классах Student и Aspirant необходимо реализовать следующие элементы:


    //конструкторы классов с соответствующим количеством параметров.В классе Aspirant для доступа к методам класса Student нужно использовать ключевое слово base;
    //    свойства get/set для доступа к полям класса;
    //    метод Print(), который выводит информацию о содержимом полей класса.


    //    Класс Aspirant и класс Student унаследоваться от Абстрактного класса Person.Класс Person реализовать общими свойствами, полями и методами классов Student и Aspirant.
    //Абстрактный класс People необходимо реализовать следующие элементы:
    //конструкторы классов с соответствующим количеством параметров. 
    //свойства get/set для доступа к полям класса;
    //    метод Print(), который выводит информацию о содержимом полей класса и продумать как переопределить их в производных классах.




    abstract class Person
    {
        public virtual string Lastname { set; get; }
        public abstract int Course { get; set; }
        public virtual int Numbook { get; set; }



        public Person()
        {

        }

        public Person(string lastname, int course, int numbook)                                        // KONSTRUKTOR PERSON
        {

            Lastname = lastname;
            Course = course;
            Numbook = numbook;

        }

        public abstract void Print();                                                                     // METOD PECHATI 

    }


    class Student : Person                                                                         // KLASS STUDENT

    {
        private int course;


        public override int Course
        {

            set

            {
                if (value >= 5)
                {
                    course = 4;

                }
                else if (value < 1)
                {

                    course = 1;
                }
                else
                {
                    course = value;
                }
            }

            get
            {
                return course;

            }


        }

        public Student() : base()
        {

        }

        public Student(string lastname, int course, int numbook)                                                            // VIZOV KONSTRUKTORA BAZI
              : base(lastname, course, numbook)
        {

        }





        public override void Print()
        {



            while (true)
            {
                Console.Write("Введите фамилию  :  ");
                Lastname = (Console.ReadLine());
                int validation;
                if (!int.TryParse(Lastname, out validation))
                {

                    Console.WriteLine(Lastname);
                    break;
                }
                Console.WriteLine("Вы ввели числа. Ведите снова");


            }



            while (true)
            {


                try
                {
                    Console.Write("Курс обучения  :  ");
                    Course = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {

                    Console.WriteLine("Пожалуйста введите только число");
                }
            }

            while (true)
            {


                try
                {
                    Console.Write("Номер зачетной книжки  :  ");
                    Numbook = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {

                    Console.WriteLine("Пожалуйста введите только число");
                }
            }



            Console.WriteLine();

            Console.WriteLine($"Lastname of Student : {Lastname}  \nCourse : {Course}  \nNumber of Book : {Numbook}\n");

        }



    }



    class Aspirant : Person                                                                                                         // KLASS ASPIRANT
    {
        private int course;

        public int Disertation { get; set; }

        public override int Course
        {

            set

            {
                if (value >= 3)
                {
                    course = 2;

                }
                else if (value < 1)
                {

                    course = 1;
                }
                else
                {
                    course = value;
                }
            }

            get
            {
                return course;

            }


        }

        public Aspirant() : base()
        {

        }


        public Aspirant(string lastname, int course, int numbook, int disertation)                                                            // VIZOV KONSTRUKTORA BAZI
            : base(lastname, course, numbook)


        {

            Disertation = disertation;

        }

        public override void Print()
        {



            while (true)
            {
                Console.Write("Введите фамилию  :  ");
                Lastname = (Console.ReadLine());

                int validation;
                if (!int.TryParse(Lastname, out validation))
                {

                    Console.WriteLine(Lastname);
                    break;
                }


                Console.WriteLine("Вы ввели числа. Ведите снова");


            }



            while (true)
            {


                try
                {
                    Console.Write("Курс обучения  :  ");
                    Course = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {

                    Console.WriteLine("Пожалуйста введите только число");
                }
            }

            while (true)
            {


                try
                {
                    Console.Write("Номер зачетной книжки  :  ");
                    Numbook = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {

                    Console.WriteLine("Пожалуйста введите только число");
                }
            }

            while (true)
            {


                try
                {
                    Console.Write("Номер диссертации :  ");
                    Disertation = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {

                    Console.WriteLine("Пожалуйста введите только число");
                }
            }




            Console.WriteLine();

            Console.WriteLine($"Lastname of Aspirant : {Lastname}  \nCourse : {Course}  \nNumber of Book : {Numbook}   \nNum of Disertation : {Disertation}\n");

        }



    }



    //class DateExam
    //{
    //    public int Day { get; set; }
    //    public int Month { get; set; }
    //    public int Year { get; set; }


    //    public override string ToString()
    //    {
    //        Console.WriteLine("Введите даты: ");
    //        //Day = int.Parse(Console.ReadLine());
    //        //Month = int.Parse(Console.ReadLine());
    //        //Year = int.Parse(Console.ReadLine());
    //        return $"{Day}.{Month}.{Year}";
    //    }




    //}





    class zadacha6
    {

        
       

        static void Main(string[] args)
        {


            Console.WriteLine("Добро пожаловать в Гарвард\n");

            //DateExam Data = new DateExam();


            do
            {


                Console.WriteLine("Код : 1 - Студенческий лагерь  \nКод: 2 - Лагерь аспирантов  ");


                string selection = (Console.ReadLine());
                switch (selection)


                {

                    case "1":

                        Console.WriteLine("Добро пожаловать в Студенческий лагерь ");

                        Student student1 = new Student();         
                        
                        //Student student2 = new Student();
                        //Student student3 = new Student();

                        student1.Print();
                        //Data.ToString();
                        //Console.WriteLine(Data.ToString());

                        //student2.Print();
                        //student3.Print();
                        Console.WriteLine("Если нужна еще информация выберите пункт 1 или 2. Для выхода нажмите кнопку Х на правом верхнем углу");
                        break;

                    case "2":

                        Console.WriteLine("Добро пожаловать в Лагерь Аспирантов");
                        Aspirant aspirant1 = new Aspirant();

                        //Aspirant aspirant2 = new Aspirant();
                        //Aspirant aspirant3 = new Aspirant();

                        aspirant1.Print();
                        //Data.ToString();
                        //aspirant2.Print();
                        //aspirant3.Print();
                        Console.WriteLine("Если нужна еще информация выберите пункт 1 или 2. Для выхода нажмите кнопку Х на правом верхнем углу");
                        break;


                    default:

                        Console.WriteLine("Нажмите на 1 или 2 или для выхода нажмите кнопку Х на правом верхнем углу");
                        break;

                }



            } while (true);



        }
    }
}
