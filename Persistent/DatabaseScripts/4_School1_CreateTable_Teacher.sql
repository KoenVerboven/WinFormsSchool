USE School1


if object_id('Teacher') is null
begin
	create table Teacher
	(
		TeacheId int identity(1,1) not null,
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
		NationalityId smallint null, 
		MoederTongueId smallint null, 
		LanguageSkill smallint null, 
		HireDate date not null,
		LeaveDate date null,
		SaleryCategorieId int null,
		SeniorityYears tinyint null,
		WorkSchedule tinyint null,
		WorkingHoursPerWeek tinyint null,
		HighestDegreeId tinyint not null,
		StudyDirection smallint not null,
		constraint PK_Teacher primary key(TeacheId),
	)
end