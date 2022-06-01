create table Student
(
studentId int not null primary key,
studentName varchar(20) not null,
dateOfBirth varchar(20) not null
)

create table Course
(
Id int not null primary key,
Name varchar(20) not null,
duration int not null,
fees varchar(20) not null
)

create table Enroll
(
StudentId int,
courseId int,
foreign key (StudentId) references Student(studentId),
foreign key(courseId) references Course(Id),
dateOfEnrollment timestamp
)


