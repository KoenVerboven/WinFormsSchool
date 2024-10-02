	Use School1
	
	Insert into Student(FirstName,MiddleName,LastName,StreetAndNumber,
	                    ZipCode,PhoneNumber,Gender,DateOfBirth, MaritalStatusId,
						NationalRegisterNumber,Nationality, [MoederTongueId],Registrationdate
						)
	values 
	('Koen','Maria Frans','Verboven','Mpad 3' , '2350','08123445','M','1966-06-01',2,1783278328,1,1,'2024-06-01  10:00:00'),
	('Johan',null,'Verboven','Mpad 3' , '2350','08123445','M','1969-01-31',2,1373737,1,1,'2024-06-01  10:00:00'),
	('Maria',null,'Poels','Mpad 3' , '2350','08123445','V','1944-04-12',2,1783837,1,1,'2024-06-01  10:00:00'),
	('Leen',null,'Peeters','Eigenaarsstraat 45 bus7' , '4000','08123445','M','1986-01-15',2,1252872,1,1,'2024-06-01  10:00:00'),
	('Gert','Frans','Peeters','Molenpad' , '4000','08123445','M','1956-02-01',2,17828,1,1,'2024-06-01  10:00:00'),
	('Jos',null,'Verhoeven','Guldensporenweg 501' , '4000','08123445','M','1944-03-19',2,1886,1,1,'2024-06-01  10:00:00'),
	('Koen',null,'Peeters','Molenpad'  , '4000','08123445','M','1935-08-07',2,18528758,1,1,'2024-06-01  10:00:00')
	

	Insert into Course(CourseName ,CourseStartDate,CourseEndDate ,MinimumGradeToPassTheCourse,
MaximumTestCourseGrade, CourseIsActive, CourseTypeId, CostPrice  
)
values
('Piano starter', '2024-06-01  10:00:00',  '2024-11-01  10:00:00', 6,10, 1,1,100),
('Piano advanced', '2024-10-01  10:00:00',  '2044-06-01  10:00:00', 6,10, 1,1,100),
('classical Giutar starter', '2024-01-01  10:00:00',  '2024-10-01  10:00:00', 6,10, 1,1,100),
('classical Giutar advanced', '2024-10-01  10:00:00',  '2024-11-01  10:00:00', 6,10, 1,1,100),
('Bass Giutar advanced', '2024-10-01  10:00:00',  '2024-11-01  10:00:00', 6,10, 1,1,100),
('Singing', '2024-10-01  10:00:00',  '2024-11-01  10:00:00', 6,10, 1,1,100),
('drum', '2023-10-01  10:00:00',  '2023-11-01  10:00:00', 6,10, 1,1,100),
('Keyboard starter', '2023-10-01  10:00:00',  '2023-11-01  10:00:00', 6,10, 1,1,100),
('saxophone', '2023-11-01  10:00:00',  '2023-12-01  10:00:00', 6,10, 1,1,100),
('French beginner', '2023-11-01  10:00:00',  '2023-12-01  10:00:00', 6,10, 1,1,100),
('French advanced', '2023-11-01  10:00:00',  '2023-12-01  10:00:00', 6,10, 1,1,100),
('Dutch beginner', '2023-11-01  10:00:00',  '2023-12-01  10:00:00', 6,10, 1,1,100),
('Dutch advanced', '2023-11-01  10:00:00',  '2023-12-01  10:00:00', 6,10, 1,1,100),
('Dutch beginner', '2023-11-01  10:00:00',  '2023-12-01  10:00:00', 6,10, 1,1,100),
('Mathematics1', '2023-11-01  10:00:00',  '2023-12-01  10:00:00', 6,10, 1,1,100),
('Mathematics2', '2023-11-01  10:00:00',  '2023-12-01  10:00:00', 6,10, 1,1,100),
('Mathematics3', '2023-11-01  10:00:00',  '2023-12-01  10:00:00', 6,10, 1,1,100),
('Chemistry1', '2023-11-01  10:00:00',  '2023-12-01  10:00:00', 6,10, 1,1,100)




Insert into StudentCourse(StudentId,CourseId,CourseTestGrade)
values
(1,1,null),
(2,1,null),
(3,1,null),
(4,1,null),
(1,2,null),
(2,2,null),
(3,2,null),
(4,2,null),
(5,8,8),
(5,10,8)


select * from Student S inner join StudentCourse SC
on S.StudentId = SC.StudentId inner join Course C
on C.CourseId = SC.CourseId