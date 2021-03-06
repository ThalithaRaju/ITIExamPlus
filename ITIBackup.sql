create database ITI
USE [ITI]
GO
/****** Object:  Table [dbo].[Exams]    Script Date: 01-06-2020 14:04:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exams](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StudentId] [int] NOT NULL,
	[Mark] [int] NOT NULL,
	[ExamName] [nvarchar](50) NULL,
	[Remarks] [nvarchar](500) NULL,
	[ExamDate] [smalldatetime] NULL,
	[TotalTime] [nvarchar](50) NOT NULL,
	[Skipped] [int] NULL,
	[Wrong] [int] NULL,
	[TotalQuestions] [int] NULL,
 CONSTRAINT [PK_Exams] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Questions]    Script Date: 01-06-2020 14:04:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Questions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Question] [nvarchar](max) NOT NULL,
	[OptionA] [nvarchar](50) NOT NULL,
	[OptionB] [nvarchar](50) NOT NULL,
	[OptionC] [nvarchar](50) NOT NULL,
	[OptionD] [nvarchar](50) NOT NULL,
	[Answer] [tinyint] NOT NULL,
	[CreatedTime] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_Questions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 01-06-2020 14:04:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[RegNumber] [nvarchar](50) NOT NULL,
	[Trade] [nvarchar](50) NOT NULL,
	[Shift] [nvarchar](50) NULL,
	[CreatedTime] [smalldatetime] NOT NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Exams] ON 

INSERT [dbo].[Exams] ([Id], [StudentId], [Mark], [ExamName], [Remarks], [ExamDate], [TotalTime], [Skipped], [Wrong], [TotalQuestions]) VALUES (1, 2, 4, N'Trail Exam', N'OS version : Microsoft Windows NT 6.2.9200.0 Syste', CAST(N'2020-04-21T17:04:00' AS SmallDateTime), N'00:01:09', 0, 2, 6)
INSERT [dbo].[Exams] ([Id], [StudentId], [Mark], [ExamName], [Remarks], [ExamDate], [TotalTime], [Skipped], [Wrong], [TotalQuestions]) VALUES (2, 5, 4, N'Trail Exam', N'OS version : Microsoft Windows NT 6.2.9200.0 Syste', CAST(N'2020-04-21T17:09:00' AS SmallDateTime), N'00:00:50', 0, 2, 6)
INSERT [dbo].[Exams] ([Id], [StudentId], [Mark], [ExamName], [Remarks], [ExamDate], [TotalTime], [Skipped], [Wrong], [TotalQuestions]) VALUES (3, 4, 3, N'Trail Exam', N'OS version : Microsoft Windows NT 6.2.9200.0 Syste', CAST(N'2020-04-21T17:11:00' AS SmallDateTime), N'00:00:30', 0, 3, 6)
INSERT [dbo].[Exams] ([Id], [StudentId], [Mark], [ExamName], [Remarks], [ExamDate], [TotalTime], [Skipped], [Wrong], [TotalQuestions]) VALUES (4, 6, 6, N'Trail Exam', N'OS version : Microsoft Windows NT 6.2.9200.0 Syste', CAST(N'2020-04-21T17:13:00' AS SmallDateTime), N'00:00:26', 0, 0, 6)
INSERT [dbo].[Exams] ([Id], [StudentId], [Mark], [ExamName], [Remarks], [ExamDate], [TotalTime], [Skipped], [Wrong], [TotalQuestions]) VALUES (5, 7, 3, N'Trail Exam', N'OS version : Microsoft Windows NT 6.2.9200.0 Syste', CAST(N'2020-04-21T17:16:00' AS SmallDateTime), N'00:00:27', 0, 3, 6)
INSERT [dbo].[Exams] ([Id], [StudentId], [Mark], [ExamName], [Remarks], [ExamDate], [TotalTime], [Skipped], [Wrong], [TotalQuestions]) VALUES (6, 8, 2, N'Trail Exam', N'OS version : Microsoft Windows NT 6.2.9200.0 Syste', CAST(N'2020-04-21T17:18:00' AS SmallDateTime), N'00:00:36', 0, 4, 6)
INSERT [dbo].[Exams] ([Id], [StudentId], [Mark], [ExamName], [Remarks], [ExamDate], [TotalTime], [Skipped], [Wrong], [TotalQuestions]) VALUES (7, 10, 4, N'Trail Exam', N'OS version : Microsoft Windows NT 6.2.9200.0 Syste', CAST(N'2020-04-23T16:42:00' AS SmallDateTime), N'00:00:35', 1, 1, 6)
SET IDENTITY_INSERT [dbo].[Exams] OFF
SET IDENTITY_INSERT [dbo].[Questions] ON 

INSERT [dbo].[Questions] ([Id], [Question], [OptionA], [OptionB], [OptionC], [OptionD], [Answer], [CreatedTime]) VALUES (4, N'Who invented the internet?', N'Charles Babbage', N'Aiyyadurai', N'Vint Cerf', N'Ray Tomlinson', 3, CAST(N'2020-04-20T20:11:00' AS SmallDateTime))
INSERT [dbo].[Questions] ([Id], [Question], [OptionA], [OptionB], [OptionC], [OptionD], [Answer], [CreatedTime]) VALUES (5, N'Who is the first Nobel Prize winner?', N'Wilhelm Rontgen', N'Rabindranath Tagore', N'Charles Gobat', N'Theodore Mommsen', 1, CAST(N'2020-04-20T20:16:00' AS SmallDateTime))
INSERT [dbo].[Questions] ([Id], [Question], [OptionA], [OptionB], [OptionC], [OptionD], [Answer], [CreatedTime]) VALUES (6, N'Inventor of Radio.', N'Nikola Tesla', N'Gugleilmo Marconi', N'Galileo Galilei', N'Alexander Graham Bell', 2, CAST(N'2020-04-20T22:26:00' AS SmallDateTime))
INSERT [dbo].[Questions] ([Id], [Question], [OptionA], [OptionB], [OptionC], [OptionD], [Answer], [CreatedTime]) VALUES (7, N'Name the Director General of World Health Organization.', N'Tedros Adhanom', N'Margaret Chan', N'Maria Van Kerkhove', N'Soumya Swaminathan', 1, CAST(N'2020-04-20T22:29:00' AS SmallDateTime))
INSERT [dbo].[Questions] ([Id], [Question], [OptionA], [OptionB], [OptionC], [OptionD], [Answer], [CreatedTime]) VALUES (8, N'Who is the current Secretary General of the United Nations?', N'Ban Ki-moon', N'Kofi Annan', N'Filippo Grandi', N'Antonio Guterres', 4, CAST(N'2020-04-20T22:46:00' AS SmallDateTime))
INSERT [dbo].[Questions] ([Id], [Question], [OptionA], [OptionB], [OptionC], [OptionD], [Answer], [CreatedTime]) VALUES (9, N'Where is the headquarters of the UNESCO situated?', N'Geneva', N'Paris', N'New York', N'Hague', 2, CAST(N'2020-04-20T22:54:00' AS SmallDateTime))
SET IDENTITY_INSERT [dbo].[Questions] OFF
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([Id], [Name], [RegNumber], [Trade], [Shift], [CreatedTime], [Password]) VALUES (2, N'Deepak', N'1000', N'MD', N'A', CAST(N'2020-04-21T14:25:00' AS SmallDateTime), N'MD')
INSERT [dbo].[Students] ([Id], [Name], [RegNumber], [Trade], [Shift], [CreatedTime], [Password]) VALUES (4, N'Amal', N'1002', N'COPA', N'B', CAST(N'2020-04-21T14:27:00' AS SmallDateTime), N'COPA')
INSERT [dbo].[Students] ([Id], [Name], [RegNumber], [Trade], [Shift], [CreatedTime], [Password]) VALUES (5, N'Akhil', N'1001', N'ICTSM', N'A', CAST(N'2020-04-21T14:27:00' AS SmallDateTime), N'ICTSM')
INSERT [dbo].[Students] ([Id], [Name], [RegNumber], [Trade], [Shift], [CreatedTime], [Password]) VALUES (6, N'Aneesha', N'1003', N'FPG', N'B', CAST(N'2020-04-21T14:29:00' AS SmallDateTime), N'FPG')
INSERT [dbo].[Students] ([Id], [Name], [RegNumber], [Trade], [Shift], [CreatedTime], [Password]) VALUES (7, N'Ajay', N'1004', N'ARCH', N'A', CAST(N'2020-04-21T14:31:00' AS SmallDateTime), N'ARCH')
INSERT [dbo].[Students] ([Id], [Name], [RegNumber], [Trade], [Shift], [CreatedTime], [Password]) VALUES (9, N'Rajesh', N'1005', N'EMECH', N'B', CAST(N'2020-04-23T15:46:00' AS SmallDateTime), N'EMECH')
INSERT [dbo].[Students] ([Id], [Name], [RegNumber], [Trade], [Shift], [CreatedTime], [Password]) VALUES (10, N'Vignesh', N'1006', N'MD', N'A', CAST(N'2020-04-23T15:47:00' AS SmallDateTime), N'MD')
SET IDENTITY_INSERT [dbo].[Students] OFF
/****** Object:  StoredProcedure [dbo].[DeleteQuestion]    Script Date: 01-06-2020 14:04:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[DeleteQuestion]
	
		@ID						INT
		
	
AS
BEGIN
	DELETE FROM [dbo].[Questions]
	WHERE Id	=	@ID
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteUser]    Script Date: 01-06-2020 14:04:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[DeleteUser]
	
		@ID						INT
		
	
AS
BEGIN
	DELETE FROM [dbo].[Students]
	WHERE Id	=	@ID
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllQuestions]    Script Date: 01-06-2020 14:04:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAllQuestions]


AS
BEGIN

	SELECT 
	[Id]
      ,[Question]
      ,[OptionA]
      ,[OptionB]
      ,[OptionC]
      ,[OptionD]
      ,[Answer]
  FROM [ITI].[dbo].[Questions]
	
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllUsers]    Script Date: 01-06-2020 14:04:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[GetAllUsers]


AS
BEGIN

	SELECT 
	 [Id]
      ,[Name]
      ,[RegNumber]
      ,[Trade]
      ,[Shift]
      ,[CreatedTime]
      ,[Password]
  FROM [dbo].[Students]
	
END
GO
/****** Object:  StoredProcedure [dbo].[GetExamCount]    Script Date: 01-06-2020 14:04:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[GetExamCount]


AS
BEGIN

	SELECT 
	COUNT(*) AS	[ExamCount]
  FROM [dbo].[Exams]
	
END
GO
/****** Object:  StoredProcedure [dbo].[GetQuestionCount]    Script Date: 01-06-2020 14:04:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetQuestionCount]


AS
BEGIN

	SELECT 
	COUNT(*) AS	[QuestionCount]
  FROM [ITI].[dbo].[Questions]
	
END
GO
/****** Object:  StoredProcedure [dbo].[GetResult]    Script Date: 01-06-2020 14:04:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetResult]


AS
BEGIN

	SELECT 
	E.[Id]
      ,	[StudentId]
	  ,	S.[Name]			AS	[Name]
	  ,	S.[RegNumber]		AS	[RegNumber]
	  ,	S.[Trade]			AS	[Trade]
	  ,	S.[Shift]			AS	[Shift]
	  ,	S.CreatedTime		AS	[CreatedTime]
      ,	[Mark]				AS	[Mark]
      ,	[ExamName]
      ,	[Remarks]
      ,	[ExamDate]
      ,	[TotalTime]
      ,	[Skipped]
      ,	[Wrong]
      ,	[TotalQuestions]
  FROM [dbo].[Exams]		AS	E
  INNER JOIN StudentS		AS	S
  ON	E.StudentId	=	S.Id
	
END
GO
/****** Object:  StoredProcedure [dbo].[GetUserCount]    Script Date: 01-06-2020 14:04:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetUserCount]


AS
BEGIN

	SELECT 
	COUNT(*) AS	[UserCount]
  FROM [dbo].[Students]
	
END
GO
/****** Object:  StoredProcedure [dbo].[SaveQuestion]    Script Date: 01-06-2020 14:04:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SaveQuestion]
	
		@ID					INT
		,	@Question		NVARCHAR(MAX)
		,	@OptionA		NVARCHAR(50)
		,	@OptionB		NVARCHAR(50)
		,	@OptionC		NVARCHAR(50)
		,	@OptionD		NVARCHAR(50)
		,	@Answer			TINYINT

	
AS
BEGIN
	IF(@ID = 0)
	BEGIN
		INSERT INTO [dbo].[Questions]
		(
			[Question]
			  ,[OptionA]
			  ,[OptionB]
			  ,[OptionC]
			  ,[OptionD]
			  ,[Answer]
			  ,[CreatedTime]
		)
		VALUES
		(
			@Question
			,	@OptionA
			,	@OptionB
			,	@OptionC
			,	@OptionD
			,	@Answer
			,	GETDATE()
		)
	END
END
GO
/****** Object:  StoredProcedure [dbo].[SaveResult]    Script Date: 01-06-2020 14:04:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SaveResult]
	
		@ID						INT
		,	@StudentId			INT
		,	@Mark				INT
		,	@ExamName			NVARCHAR(50)
		,	@Remarks			NVARCHAR(50)
		,	@ExamDate			SMALLDATETIME
		,	@TotalTime			NVARCHAR(50)
		,	@Skipped			INT
		,	@Wrong				INT
		,	@TotalQuestions		INT

	
AS
BEGIN
	INSERT INTO [dbo].[Exams]
	(
		[StudentId]
		,	[Mark]
		,	[ExamName]
		,	[Remarks]
		,	[ExamDate]
		,	[TotalTime]
		,	[Skipped]
		,	[Wrong]
		,	[TotalQuestions]
	)
	VALUES
	(
		@StudentId
		,	@Mark
		,	@ExamName
		,	@Remarks
		,	GETDATE()
		,	@TotalTime
		,	@Skipped
		,	@Wrong
		,	@TotalQuestions
	)
END
GO
/****** Object:  StoredProcedure [dbo].[SaveStudent]    Script Date: 01-06-2020 14:04:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SaveStudent]
	
		@Id				INT
		,	@Name		NVARCHAR(50)
		,	@RegNumber	NVARCHAR(50)
		,	@Trade		NVARCHAR(50)
		,	@Shift		NVARCHAR(50)

	
AS
BEGIN
	INSERT INTO [dbo].[Students]
	(
		[Name]
		  ,[RegNumber]
		  ,[Trade]
		  ,[Shift]
		  ,[CreatedTime]
		  ,[Password]
	)
	VALUES
	(
		@Name
		,	@RegNumber
		,	@Trade
		,	@Shift
		,	GETDATE()
		,	@Trade
	)
END
GO
/****** Object:  StoredProcedure [dbo].[StudentLogin]    Script Date: 01-06-2020 14:04:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[StudentLogin]
	
			@RegNumber		NVARCHAR(50)
		,	@Password		NVARCHAR(50)

	
AS
BEGIN
	SELECT 
		[Id]
		,	[Name]
		,	[RegNumber]
		,	[Password]
		,	[Trade]
		,	[Shift]
		,	[CreatedTime]
	FROM [dbo].[Students]
	WHERE	[RegNumber]	=	@RegNumber
	AND		[Password]		=	@Password
END
GO
