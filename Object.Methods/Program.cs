using System;
using System.Security.Cryptography.X509Certificates;

namespace inheritance

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

        public override int GetHashCode()
        {
            return Lastname.GetHashCode();
        }

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
                Console.Write("\tВведите фамилию  :  ");
                Lastname = (Console.ReadLine());


                int validation;
                if (!int.TryParse(Lastname, out validation))
                {

                    Console.WriteLine();
                    break;
                }
                Console.WriteLine("\tВы ввели числа. Ведите снова");


            }



            while (true)
            {


                try
                {
                    Console.Write("\tКурс обучения  :  ");
                    Course = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {

                    Console.WriteLine("\tПожалуйста введите только число");
                }
            }

            while (true)
            {


                try
                {
                    Console.Write("\tНомер зачетной книжки  :  ");
                    Numbook = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {

                    Console.WriteLine("\tПожалуйста введите только число");
                }
            }



            Console.WriteLine();

            Console.WriteLine($" \t\tLastname of Student : {Lastname}  \n\t\tCourse : {Course}  \n \t\tNumber of Book : {Numbook}\n");

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
                Console.Write("\tВведите фамилию  :  ");

                Lastname = (Console.ReadLine());




                int validation;
                if (!int.TryParse(Lastname, out validation))
                {

                    Console.WriteLine();
                    break;
                }


                Console.WriteLine("\tВы ввели числа. Ведите снова");


            }



            while (true)
            {


                try
                {
                    Console.Write("\tКурс обучения  :  ");
                    Course = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {

                    Console.WriteLine("\tПожалуйста введите только число");
                }
            }



            while (true)
            {


                try
                {
                    Console.Write("\tНомер зачетной книжки  :  ");
                    Numbook = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {

                    Console.WriteLine("\tПожалуйста введите только число");
                }
            }



            while (true)
            {


                try
                {
                    Console.Write("\tНомер диссертации :  ");
                    Disertation = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {

                    Console.WriteLine("\tПожалуйста введите только число");
                }
            }




            Console.WriteLine();

            Console.WriteLine($" \t\tLastname of Aspirant : {Lastname}  \n \t\tCourse : {Course}  \n \t\tNumber of Book : {Numbook}   \n \t\tNum of Disertation : {Disertation}\n");

        }



    }


    class DataExam
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public override string ToString()
        {
            return $"{Day}.{Month}.{Year}\n";
        }
    }






    class program
    {


        static void Main(string[] args)
        {



            //Aspirant aspirant1 = new Aspirant();
            //Aspirant aspirant2 = new Aspirant();


            Console.WriteLine("\t\t Д о б р о   п о ж а л о в а т ь   в   Г а р в а р д. \n".ToUpper());



            do
            {


                Console.WriteLine("Код : 1 - Студенческий лагерь________________Код: 2 - Лагерь аспирантов  \n");


                string selection = (Console.ReadLine());
                switch (selection)


                {

                    case "1":

                        Console.WriteLine("\t\tДобро пожаловать в Студенческий лагерь \n".ToUpper());

                        Student student1 = new Student();
                        Console.WriteLine(student1.GetType());                                         // GET TYPE 

                        Student student2 = new Student();
                        //Student student3 = new Student();

                        Console.WriteLine("Информация о 1-м Студенте\n.".ToUpper());
                        student1.Print();
                        Console.WriteLine("Информация о 2-м Студенте\n");
                        student2.Print();
                        //student3.Print();


                        Console.WriteLine("Дата экзамена: ");
                        DataExam ExamS = new DataExam { Day = 07, Month = 11, Year = 2020 };
                        Console.WriteLine(ExamS.ToString());                                                 // TO STRING  DATE



                        bool SEqual = student1.Equals(student2);                                            // EQUALS
                        Console.WriteLine("Are the types equal ?: " + SEqual);


                        Console.Write("Сумма ХэшКодов: ");
                        Console.WriteLine(student1.GetHashCode() + student2.GetHashCode());                // GET HASH CODE
                        Console.WriteLine();

                        Console.WriteLine("Если нужна еще информация выберите пункт 1 или 2. Для выхода нажмите кнопку Х на правом верхнем углу\n");
                        break;



                    case "2":

                        Console.WriteLine("\t\tДобро пожаловать в Лагерь Аспирантов\n".ToUpper());

                        Aspirant aspirant1 = new Aspirant();

                        Aspirant aspirant2 = new Aspirant();

                        //Aspirant aspirant3 = new Aspirant();
                        Console.WriteLine("Информация о 1-м Аспиранте\n.".ToUpper());
                        aspirant1.Print();
                        Console.WriteLine("Информация о 2-м Аспиранте\n.".ToUpper());
                        aspirant2.Print();
                        //aspirant3.Print();


                        Console.WriteLine("Дата экзамена: ");
                        DataExam ExamA = new DataExam { Day = 12, Month = 11, Year = 2020 };
                        Console.WriteLine(ExamA.ToString());                                               // TO STRING DATE 



                        Console.Write("Сумма ХэшКодов: ");
                        Console.WriteLine(aspirant1.GetHashCode() + aspirant2.GetHashCode());                // GET HASH CODE
                        Console.WriteLine();


                        bool AEqual = aspirant1.Equals(aspirant2);
                        Console.WriteLine("Are the types equal ?: " + AEqual);                                             // EQUALS

                        Console.WriteLine("Если нужна еще информация выберите пункт 1 или 2. Для выхода нажмите кнопку Х на правом верхнем углу\n");
                        break;


                    default:

                        Console.WriteLine("Нажмите на 1 или 2 или для выхода нажмите кнопку Х на правом верхнем углу");
                        break;

                }






                // EQUALS

            } while (true);



        }
    }
}
