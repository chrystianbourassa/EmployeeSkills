

INSERT [Categories] ([Description]) VALUES (N'Application Development')
INSERT [Categories] ([Description]) VALUES (N'Network architect')
INSERT [Categories] ([Description]) VALUES (N'IT technician')
INSERT [Categories] ([Description]) VALUES (N'Database administrator')
INSERT [Categories] ([Description]) VALUES (N'Computer programmer')


INSERT [SubCategories] ([Description], [CategoryID]) VALUES (N'Mobile Apps', 5)
INSERT [SubCategories] ([Description], [CategoryID]) VALUES (N'Web Apps', 5)
INSERT [SubCategories] ([Description], [CategoryID]) VALUES (N'Desktop Applications', 5)

INSERT [Cities] ([Name]) VALUES (N'Montréal')
INSERT [Cities] ([Name]) VALUES (N'Québec')
INSERT [Cities] ([Name]) VALUES (N'Laval')
INSERT [Cities] ([Name]) VALUES (N'Gatineau')
INSERT [Cities] ([Name]) VALUES (N'Longueuil')
INSERT [Cities] ([Name]) VALUES (N'Sherbrooke')
INSERT [Cities] ([Name]) VALUES (N'Trois-Rivières')

INSERT [Employees] ([FullName], [BirthDate], [HireDate], [Address], [PostalCode], [Country], [HomePhone], [Notes], [ProfilePictureURL], [ResumePath], [CityID]) VALUES (N'Chrystian Bourassa', CAST(N'1967-10-06T00:00:00.0000000' AS DateTime2), CAST(N'2019-05-05T00:00:00.0000000' AS DateTime2), N'652 Pine Av.', N'J0W1K0', N'Canada', N'587-601-5236', NULL, NULL, NULL, 1)
INSERT [Employees] ([FullName], [BirthDate], [HireDate], [Address], [PostalCode], [Country], [HomePhone], [Notes], [ProfilePictureURL], [ResumePath], [CityID]) VALUES (N'Benoit Desjardins', CAST(N'1980-10-10T00:00:00.0000000' AS DateTime2), CAST(N'2015-06-13T00:00:00.0000000' AS DateTime2), N'4562 rue Melancon', N'J0W1K0', N'Canada', N'514-852-9746', NULL, NULL, NULL, 1)
INSERT [Employees] ([FullName], [BirthDate], [HireDate], [Address], [PostalCode], [Country], [HomePhone], [Notes], [ProfilePictureURL], [ResumePath], [CityID]) VALUES (N'Marc Perreault', CAST(N'1979-05-15T00:00:00.0000000' AS DateTime2), CAST(N'2020-09-24T00:00:00.0000000' AS DateTime2), N'8888 Chagnon', N'J0W1K0', N'Canada', N'514-725-9254', NULL, NULL, NULL, 1)
INSERT [Employees] ([FullName], [BirthDate], [HireDate], [Address], [PostalCode], [Country], [HomePhone], [Notes], [ProfilePictureURL], [ResumePath], [CityID]) VALUES (N'Sophie Martineault', CAST(N'1985-06-06T00:00:00.0000000' AS DateTime2), CAST(N'2014-07-12T00:00:00.0000000' AS DateTime2), N'89000 Henri-Bourassa', N'J0W1K0', N'Canada', N'403-985-4625', NULL, NULL, NULL, 1)
INSERT [Employees] ([FullName], [BirthDate], [HireDate], [Address], [PostalCode], [Country], [HomePhone], [Notes], [ProfilePictureURL], [ResumePath], [CityID]) VALUES (N'Genevieve Morin', CAST(N'1990-11-15T00:00:00.0000000' AS DateTime2), CAST(N'2012-11-21T00:00:00.0000000' AS DateTime2), N'96 Morin Sud', N'J0W1K0', N'Canada', N'819-789-6431', NULL, NULL, NULL, 2)
INSERT [Employees] ([FullName], [BirthDate], [HireDate], [Address], [PostalCode], [Country], [HomePhone], [Notes], [ProfilePictureURL], [ResumePath], [CityID]) VALUES (N'Luc Melancon', CAST(N'1965-10-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-01-13T00:00:00.0000000' AS DateTime2), N'9090 Sheldon st.', N'J0W1K0', N'Canada', N'819-573-9514', NULL, NULL, NULL, 2)
INSERT [Employees] ([FullName], [BirthDate], [HireDate], [Address], [PostalCode], [Country], [HomePhone], [Notes], [ProfilePictureURL], [ResumePath], [CityID]) VALUES (N'Martin Labelle', CAST(N'1978-11-03T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-07T00:00:00.0000000' AS DateTime2), N'8675 44st SE', N'J0W1K0', N'Canada', N'514-898-8965', NULL, NULL, NULL, 3)
INSERT [Employees] ([FullName], [BirthDate], [HireDate], [Address], [PostalCode], [Country], [HomePhone], [Notes], [ProfilePictureURL], [ResumePath], [CityID]) VALUES (N'Maurice Benoit', CAST(N'1975-05-08T00:00:00.0000000' AS DateTime2), CAST(N'2018-10-10T00:00:00.0000000' AS DateTime2), N'987 Ontario E.', N'J0W1K0', N'Canada', N'514-322-5681', NULL, NULL, NULL, 4)
INSERT [Employees] ([FullName], [BirthDate], [HireDate], [Address], [PostalCode], [Country], [HomePhone], [Notes], [ProfilePictureURL], [ResumePath], [CityID]) VALUES (N'Martin Petit', CAST(N'1990-11-15T00:00:00.0000000' AS DateTime2), CAST(N'2017-06-15T00:00:00.0000000' AS DateTime2), N'9090 Ste-Catherine', N'J0W1K0', N'Canada', N'819-688-2876', NULL, NULL, NULL, 4)

INSERT [Interests] ( [Description]) VALUES (N'Pas interessé')
INSERT [Interests] ( [Description]) VALUES (N'Peu interessé')
INSERT [Interests] ( [Description]) VALUES (N'Interessé')
INSERT [Interests] ( [Description]) VALUES (N'Très interessé')
INSERT [Interests] ( [Description]) VALUES (N'Hautement interessé.')


INSERT [Levels] ( [Description]) VALUES (N'Stagiaire')
INSERT [Levels] ( [Description]) VALUES (N'Débutant')
INSERT [Levels] ( [Description]) VALUES (N'Intermédiaire')
INSERT [Levels] ( [Description]) VALUES (N'Professionel')
INSERT [Levels] ( [Description]) VALUES (N'Expert.')