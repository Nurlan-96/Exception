using ExceptionPractice.Entities;

Student student1 = new Student("Alice", "Johnson", 20, 85);
Student student2 = new Student("Bob", "Smith", 21, 78);
Student student3 = new Student("Charlie", "Brown", 19, 92);
Student student4 = new Student("David", "Williams", 22, 79);
Student student5 = new Student("Eva", "Davis", 20, 88);
Student student6 = new Student("Michael", "Dawson", 22, 100);
Student student7 = new Student("John", "Doe", 20, 85);
Student student8 = new Student("Alice", "Smith", 22, 78);
Student student9 = new Student("Emma", "Johnson", 21, 90);
Student student10 = new Student("Michael", "Williams", 23, 95);
Student student11 = new Student("Mike", "Myers", 54, 67);

Group group = new Group(5,10);
group.AddStudent(student1);
group.AddStudent(student2);
group.AddStudent(student3);
group.AddStudent(student4);
group.AddStudent(student5);
group.AddStudent(student6);
group.AddStudent(student7);
group.AddStudent(student8);
group.AddStudent(student9);
group.AddStudent(student10);
//group.AddStudent(student11); exception gelecek
//group.GetStudent();
group.GroupInfo(); //Ap101 yazilir

Group group1 = new Group(5, 10);
group1.AddStudent(student1);
group1.AddStudent(student2);
group1.AddStudent(student3);
group1.AddStudent(student4);
group1.SortbyPoint();
group1.GroupInfo(); //AP102 yazilir
//student6.ShowInfo();


