create database GradingSystem
go
use GradingSystem

create table Account(
	AccountID int identity(1,1) not null,
	AccountUserName varchar(30) unique not null,
	AccountPassword varchar(50) not null,
	AccountRole varchar(20) not null,
	constraint pk_Account primary key (AccountID)
)

create table Teacher(
	TeacherID int identity(1,1) not null,
	TeacherAccountID int not null,
	TeacherName nvarchar(100) not null,
	TeacherPhoneNumber varchar(12),
	TeacherMail varchar(200),
	constraint pk_Teacher primary key (TeacherID),
	constraint fk_TeacherAccountID foreign key (TeacherAccountID) references Account(AccountID)
)

create table Class(
	ClassID int identity(1,1) not null,
	ClassName nvarchar(50) not null,
	constraint pk_Class primary key (ClassID)
)

create table Student(
	StudentID int identity(1,1) not null,
	StudentClassID int not null,
	StudentAccountID int unique not null,
	StudentName nvarchar(100) not null,
	StudentPhoneNumber varchar(12),
	StudentMail varchar(200),
	constraint pk_Student primary key (StudentID),
	constraint fk_StudentAccountID foreign key (StudentAccountID) references Account(AccountID),
	constraint fk_StudentClassID foreign key (StudentClassID) references Class(ClassID)
)

create table Course(
	CourseID int identity(1,1) not null,
	CourseName varchar(50) not null,
	constraint pk_Course primary key (CourseID)
)

create table Teaching(
	TeachingTeacherID int not null,
	TeachingCourseID int not null,
	TeachingClassID int not null,
	constraint pk_Teaching primary key (TeachingTeacherID, TeachingCourseID, TeachingClassID),
	constraint fk_TeachingTeacherID foreign key (TeachingTeacherID) references Teacher(TeacherID),
	constraint fk_TeachingCourseID foreign key (TeachingCourseID) references Course(CourseID),
	constraint fk_TeachingClassID foreign key (TeachingClassID) references Class(ClassID),
	constraint uc_ClassCourse unique(TeachingClassID, TeachingCourseID)
)

create table Grade(
	GradeStudentID int not null,
	GradeCourseID int not null,
	AttendanceGrade int default 0,
	ProjectGrade int default 0,
	WrittenGrade int default 0,
	PracticalExamGrade int default 0,
	FinalExamGrade int default 0,
	AverageGrade int default 0,
	ResultText varchar(10),
	constraint pk_Grade primary key (GradeStudentID, GradeCourseID),
	constraint fk_GradeStudentID foreign key (GradeStudentID) references Student(StudentID),
	constraint fk_GradeCourseID foreign key (GradeCourseID) references Course(CourseID)
)

create view CourseGradeReport as
select GradeStudentID, CourseName, AttendanceGrade, ProjectGrade,WrittenGrade, PracticalExamGrade, FinalExamGrade, AverageGrade, ResultText
from Grade inner join Course on Grade.GradeCourseID =Course.CourseID 

insert into Account values 
('tea2033', '123123', 'Teacher'),
('tea2034', '123123', 'Teacher'),
('stu1301', 'huutinh', 'Student'),
('stu1302', 'baohieu', 'Student'),
('stu1303', 'tanhoang', 'Student'),
('stu1304', 'quangphu', 'Student'),
('stu1305', 'quockhanh', 'Student')

select * from Teacher
insert into Teacher values 
(1, 'Holger Nielsen', '88888888', 'holgernielsen@gradsys.com'),
(2, 'John Schwarz', '99999999', 'jonhschwarz@gradsys.com')

insert into Class values
('SE001'), ('SE002'), ('SE003');

insert into Student values
(1, 3, N'Hồ Hữu Tình', '0905123456', 'tinhh@gradsys.com'),
(1, 4, N'Nguyễn Thanh Bảo Hiếu', '0905112455', 'hieuntb@gradsys.com'),
(3, 5,N'Phạm Tấn Hoàng', '0905122354', 'hoangpt@gradsys.com'),
(3, 6,N'Nguyễn Hoàng Quang Phú', '0905133231', 'phunhq@gradsys.com'),
(2, 7,N'Trần Quốc Khánh', '0905765982', 'khanhtq@gradsys.com')

insert into Course values
('Fundamental of String Theory'), ('Supersymmetric String Theory')

insert into Teaching values
(1,1,1), (1,1,2), (1,2,3), (2,2,1), (2,2,2), (2,1,3)

--insert into Grade values
--bảng này tùy vào cơ cấu điểm của các bạn nên tốt nhất không nên có dữ liệu mặc định