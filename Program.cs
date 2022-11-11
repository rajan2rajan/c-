// to run the program we need to use 

// dotnet run


// printing hellow world in c#

// using System;
// public class programming{
//     public static void Main(string[] args)
//     // here static means without creating any object we can access this method
//     {
//         Console.WriteLine("hellow C#");
//         // to prevent the screen from running and closing quickly and also using readline we can get input  from user.
//         Console.ReadLine();
//     }
// }




// if else statement 


// public class rajan{
//     public static void Main(string[] args)
//     {
//     Console.WriteLine("enter the number:-");
//     int i =Convert.ToInt32(Console.ReadLine());
//     //  first read the data and convert it in to integer
//     if (i%2== 0)
//         Console.WriteLine("it is an integer");
//     else
//         Console.WriteLine("this is not dividible by 2");

//     }

// }



// public class letter{
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("what is the string you want to check");
//         string a = Convert.ToString(Console.ReadLine());
//         if (a.StartsWith("a"))
//             Console.WriteLine("this letter starts with a");
//         else
//             Console.WriteLine("this letter doesnot starts with a ");
        
        
//     }
// }





// using System;
// namespace rajan{
//     class My_name{

//         public static void Main(string[] args)
//         {
//             Console.WriteLine("this is bad");
//             Console.ReadLine();
//         }
//     }
//     class My_age{
//         public static void Main(string[] args)
//         {
//             Console.WriteLine("my age is 21");
//             Console.ReadLine();
//         }
//     }
// }



// if else statement


// using System;

// namespace Ifelse_statement{
//     class rajan{
//         public static void Main(string[] args){
//             Console.WriteLine("this is today begining");
//             Console.WriteLine("first if and else condtion example");
//             string name= "rajanbhandari";
//             string resutl = Console.ReadLine();
//             if (name==resutl)
//                 Console.WriteLine("that is true");
//             else
//                 Console.WriteLine("this is bad");
             
//         }
//     }

// }





// getting input from user in integer form

// using System;
// namespace TakingInput{
//     class calculator{
//         public static void Main(string[] args){
//             int a,b;
//             Console.WriteLine("enter two integer for operation");
//             a= int.Parse(Console.ReadLine());
//             b= int.Parse(Console.ReadLine());
//             Console.Write(a*b);
            

//         }
//     }
// }


// using switch statement 


// using System;
// namespace Switchstatement{

//     // switch statement for number using add , multiplication , division ...
//     class number{
//        public static void Main(string[]  args){
//         int a ,b ,op;
//         Console.WriteLine("enter the first number");
//         a = int.Parse(Console.ReadLine());
//         Console.WriteLine("enter the second number :");
//         b = int.Parse(Console.ReadLine());
//         Console.WriteLine("what operation you want to perform");
//         Console.WriteLine("1: addiation , 2:substraction , 3:multiplication , 4: division");
//         op = int.Parse(Console.ReadLine());

//         // hami la data op ma rakhako xam mathi kun number ma ho vanara so  same data switch ma janxa ra tehi anusar operation hunxa
//         switch (op)
//         {
//             case 1:
//                 Console.WriteLine("add  = " + (a+b));
//                 break;

//             case 2:
//                 Console.WriteLine("substraction  = " + (a-b));
//                 break;

//             case 3:
//                 Console.WriteLine("multiplication  = " + (a*b));
//                 break;

//             case 4:
//                 Console.WriteLine("division  = " + (a/b));
//                 break;

//             default:
//                 Console.WriteLine("wrong operation  ");
//                 break;

            
//         }

//        }
//     }


// //  if we have to take care with character ;

// // taking input string

//     class stringe{
//         public static void Main(string[] args){
//             string mystr;
//             Console.WriteLine("what is the name of  your country: ");
//             mystr = Console.ReadLine();
//             switch (mystr){
//                 case "nepal":
//                     Console.WriteLine("you are the best");
//                     break;
                
//                 case "america":
//                     Console.WriteLine("you traitor ");
//                     break;

//                 default:
//                     Console.WriteLine("do what ever you want to do");
//                     break;
//             }
        
//         }
//     }
// }







// looping 

// using System;
// namespace looping{
//     class forloop{
//         public static void Main(string[] args){
//             Console.WriteLine("here we are using 3 different loop : for , foreach , while and do/while loop");
//             int a,i;
//             Console.WriteLine("what is the numbe you want to print:");
//             a = int.Parse(Console.ReadLine());
//             Console.WriteLine("the remaning numbers are:");
//             for(i=a;i<5;i++){
//                 Console.WriteLine(i);
//             }

//         }
//     }

//         //foreachloop : they are used when we itterate through list of data

//     class foreachloop{
//         public static void Main(string[] args){
//             // yo kun type ko ho   . . yesko name    =   memory allocation for 5/number  string      {data}
//             string[] country = new string [5] { "nepal" , "china" , "russia" , "austrialia" , "singapore" };
//             foreach (var item in country)
//             {
//                 Console.WriteLine(item);
//             }
//         }
        
//     }

// //  using whileloop:  if we dont know kati patak program run garna parxa vana while loop use garixa

//     class whileloop{
//         public static void Main(string[] args){
//             Console.WriteLine("from the number you want to start:");
//             int a = int.Parse(Console.ReadLine());
//             Console.WriteLine("what is the limit you want to have");
//             int b = int.Parse(Console.ReadLine());
//             int count=a;
//             Console.WriteLine("the count starts now");
//             while (a<b){               
//                 Console.WriteLine(count);
//                 count++;
//                 if (count>b)
//                     break;

//             }
//         }
//     }

// // do while loop: tha xain kati khera sama program run garna parxa tara 1 patak chi jasari vaya pani program run garna nai parxa

//     class dowhileloop{
//         public static void Main(string[] args){
//             Console.WriteLine("from the number you want to start:");
//             int a = int.Parse(Console.ReadLine());
//             Console.WriteLine("what is the limit you want to have");
//             int b = int.Parse(Console.ReadLine());
//             Console.WriteLine("the program starts now");

//             do{
//                 Console.WriteLine(a);
//                 a++;

//             }while(a<=b);

//         }    
//     }
// }




// here we are using jump statement and there are 3 method



// using System;
// namespace Jumpstatement{

    // yedi hami la tehi thau bata program terminate garna xa vana hami la break statement use garxam
    // class Break{
    //         // to get random number we use
    //         // Random a = new Random();
    //         // int ran = a.Next(1,11)
    //     public static void Main(string[] args){
    //         Console.WriteLine("what is the number you are guessing between 1 and 10: ");
    //         Random a =new Random();
    //         int i;
    //         int c = a.Next(1,11);
    //         for (i=1;i<=10;i++){
    //             Console.WriteLine(i);
    //             if (i==c){
    //                 break;
    //             }
                
    //         }
    //     }
    // }


// yedi hami la kuni program ko line remove garna xa vana continue use garinxa
    // class Continue{
    //     public static void Main(string[] args){
    //         Console.WriteLine("which number you want to remove btwn 1 and 10:");
    //         int a = int.Parse(Console.ReadLine());
    //         int i;
    //         for(i=1;i<10;i++){
    //             if(i==a){
    //                 continue;
    //             }
    //             Console.WriteLine(i);
    //         }
    //     }
    // }



    // goto la 1 thau ko program lai arko thau ma laijana kam garxa


    // class Goto{
    //     public static void Main(string[] args){
    //         Console.WriteLine("which number you want to remove btwn 1 and 10:");
    //         int a = int.Parse(Console.ReadLine());
    //         int i;
    //         for(i=1;i<10;i++){
    //             if(i==a){
    //                 goto x;
    //                 x:
    //                     Console.WriteLine("user had input:" +a)  ;
    //                     continue;
    //             }
    //             Console.WriteLine(i);
                

    //         }
    //     }
    // }
// }



// methods in c# or  function


// using System;
// namespace Methodcreation{
    // class MethodDecleration{
    //     // this is the main fumction from where program run to start
       
    //     public static void Main(string[] args){
    //         print();
    //         Console.WriteLine(addiation(1,2));
    //     }
    //     // this is the function define which return nothing
    //     // accesstype   ... return typeof   .. name of function
    //     public static void print(){

    //         Console.WriteLine("the sum of two numbers are : ");
    //     }
    //     // this is the program which return the data type int
    //     public static int addiation(int a , int b){
    //         int add = a + b;
    //         return add;
    //     }
    // }



    // class DefaultValue{
    //     // DefaultValue but  if we pass value then it will change to other as given
    //     public static void Main(string[] args){

    //         name();
    //     }
    //     static void name(string child1="ram",string child2="shyam", string child3="laxman"){
    //         Console.WriteLine("the elder brother is "+child3);
    //         Console.WriteLine("the smallest brother is "+child1);
    //         Console.WriteLine("the middle brother is "+child2);
    //     }
    // }


    // class FunctionOverloading{

    //     // FunctionOverloading means have same function name but different parameter weather by name or type of parameter
    //     public static void Main(string[] args){
    //         data("rajan","23");
    //         data(1,23);
    //     }
    //     static void data(string name , string age){
    //         Console.WriteLine("your name is " + name);
    //         Console.WriteLine("your age is " + age);


    //     }
    //     static int data(int name , int age){
    //         Console.WriteLine("your name is " + name);
    //         Console.WriteLine("your age is " + age);
    //         return 0;

    //     }

    // }

// }




// Array and string



// using System;
// namespace ArrayAndString{
//     class String{
    //     public static void Main(string[] args){
    //         // PrintString();
    //         // Concatenation();
    //         // FirstLetter();
    //     }
    //     static void PrintString(){
    //         string data = "printing data in C#";
    //         Console.WriteLine(data);
    //         Console.WriteLine(data.ToUpper());
    //         Console.WriteLine(data.ToLower());
    //         Console.WriteLine(data.Length);

    //     }
    //     static void Concatenation(){
    //         string Firstname = "Rajan";
    //         string SecondName = " Bhandari";
    //         Console.WriteLine(Firstname + SecondName);
    //         // or
    //         string Fullname = string.Concat(Firstname , SecondName);
    //         Console.WriteLine(Fullname);

    //     }

    //     static void FirstLetter(){
    //         string letter = "First";
    //         Console.WriteLine(letter[0]);
    //     }
    // }

//     class Array{
//         public static void Main(string[] args){
//             // CreatingArray();
//             Multidimension();
//         }
//         static void CreatingArray(){
//             string[] a = new string[] {"ram","Rajan","Bhandari","shyam","laxman"};
//             // if size is known otherwise 
//             string[] b ={"ram","keerti","Bhandari","shyam","laxman"};

//             Console.WriteLine("My Firstname is " +a[1]+" and lastname is " + a[2]);
//             Console.WriteLine("My Sister Firstname is " +b[1]+" and lastname is " + b[2]);

            
//         }
//         static void Multidimension(){
//             int[,] a= new int[,]{{1,2},{2,3},{3,4}};
//             Console.WriteLine(a[2,1]);
//         }

//     }
// }


// object oriented programming language



// using System;
// namespace ObjectOriented{
//     class Student{
//         public int id , age;
//         public string name, subject;
//     }
//     class Object{
//         public static void Main(string[] args){
//             Student s = new Student();
//             s.name= "rajan";
//             s.id = 1;
//             s.age = 5;
//             s.subject = "science";

//             Console.WriteLine(s.name);

//             Student s1 = new Student();
//             s1.name = "keerti";
//             s1.age = 18;
//             s1.subject ="science";
//             s1.id = 10;

//             Console.WriteLine(s1.name);
//         }
//     }
// }




// constructor




// using System;
// namespace Constructor{
//     class Program{
//         public static void Main(string[] args){
//             // class name   variable to define   =  Memory allocation     constructor calling(passing data)
//             Book b = new Book("pokhara","keerti",10,100);

//             // if want to change the existing data then 
//             b.Name = "chitwan";
//             Console.WriteLine(b.Name);
//         }
//     }
//     class Book{
//         public string Arthur, Name;
//         public int Price, Page;

//         public Book(string name,string arthur,int page,int price){
//             Name = name;
//             Arthur = arthur;
//             Price = price;
//             Page = page;
//         }
//     }
// }


// object  with method: calling method  


// using System;
// namespace objectMethod{
//     class Program{
//         public static void Main(string[] args){
//             Student s = new Student("rajan","csit",5);
//             Student s1 = new Student("keerti","nurse",10);
//             Console.WriteLine(s1.name);

//         }
//     }

//     class Student{
//         public string name,subject;
//         public int gpa;

//         public  Student(string aname,string asubject,int agpa){
//             name = aname;
//             subject = asubject;
//             gpa = agpa;
//         }

//         public  bool check(){
//             if (gpa>2)
//                 return true;
            
//             else
//                 return false;
//         }

//     }
// }


// with  using static 

// using System;
// namespace rajan2rajan{
//     class program{
//         public static void Main(string[] args){
        
//             Console.WriteLine(usingstatic.sum(1,2));
//         }
//     }
//     class usingstatic{
//         public static  int sum(int a, int b){
//             return a+b;
//         } 
//     }
// }


// without using static


// using System;
// namespace rajan2rajan{
//     class program{
//         public static void Main(string[] args){
//             withoutstatic a = new withoutstatic();
//             Console.WriteLine(a.sum(1,2));
//         }
//     }

//     class withoutstatic{
//         public int sum(int a , int b){
//             return a+b;
//         }
//     }

// }


// getter and setter


// using System;
// namespace getterandsetter{
//     class program{
//         public static void Main(string[] args)
//         {
//             data a = new data();
//             a.a=2;
//             Console.WriteLine(a.sum(2));
//         }
//     }

//     class data{
//         public int a{get; set;}
//         public int sum(int a ){
//             return a+a;
//         }
        
//     }
// }



// this in C#


// using System;
// namespace rajan2rajan{
//     class program{
//         public static void Main(string[] args)
//         {
//             thisdemo p = new thisdemo(1,2);
            
//         }
//     }
//     class thisdemo{

//         int l;int b;
//         public thisdemo(int length , int breath){
//             this.l=length;
//             this.b = breath;

//             Console.WriteLine("values are {0} {1}",this.l , this.b);
//         }
//     }
// }




// paramatarized constructor with this keyword



// using System;
// namespace rajan2rajan{
//     class program{
//         public static void Main(string[] args){
//             result r = new result(1,"hacker", "F");
//             r.final();
//         }
//     }
//     class result{
//         int id ; string name ,g;
//         public result(int id , string fullname , string gender){
//             this.id = id;
//             this.name  = fullname;
//             this.g = gender;        
//         }
//         public  void final(){
//             Console.WriteLine("id={0} name ={1}  gender={2}",id,name,g);
//         }
//     }
// }




// inheriatance


// using System;
// namespace rajan2rajan{
//     class Inheriatance{
//         public static void Main(string[] args)
//         {
//             // rectangle r = new rectangle();
//             square s = new square();
            
//         }
//     }
//     class rectangle{
//         protected int length=5,breath=6,area;
//         public rectangle(){
//             area = length * breath;
//             Console.WriteLine("the area of rectangle is {0}",area);
//         }
//     }
//     class square:rectangle{
//         public square(){
//             area = length*length;
//             Console.WriteLine("the area of square is {0}",area);
//         }
//         public new void show(){
//             Console.WriteLine("this is good");
//             }
            
          
//     }
// }
