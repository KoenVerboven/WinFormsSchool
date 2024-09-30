USE School1


if object_id('Student') is null
begin
	create table Student
	(
		StudentId int identity(1,1) not null,
		FirstName varchar(50) not null,
		MiddleName varchar(50) null,
		LastName varchar(50) not null,
		StreetAndNumber varchar(60) not null,
		ZipCode varchar(6) not null,
		PhoneNumber varchar(10) null,
		EmailAddress varchar(60) null,
		Gender char not null,
		DateOfBirth date not null,
		MaritalStatusId tinyint not null, 
		NationalRegisterNumber smallint null, 
		Nationality smallint null, 
		MoederTongueId smallint null, 
		LanguageSkill smallint null, 
		Registrationdate date not null,
		constraint PK_Student primary key(StudentId),
	)
end