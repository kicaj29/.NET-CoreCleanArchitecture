/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[Name]
      ,[Description]
      ,[ImageUrl]
  FROM [UniversityDB].[dbo].[Courses]


  INSERT INTO Courses (Name, Description, ImageUrl)
  VALUES
  ('Physics', 'Introduction to Physics', '/images/art-ball-shaped-circle-414860.jpg'),
  ('Chemistry', 'Introduction to Chemistry', '/images/blue-bubble-crystal-clear-132477.jpg'),
  ('Mathematics', 'Introduction to Mathematics', '/images/book-education-graphing-paper-167682.jpg')