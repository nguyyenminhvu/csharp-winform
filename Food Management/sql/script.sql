USE [FoodManagement]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 4/28/2023 10:57:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[Username] [nvarchar](100) NOT NULL,
	[DisplayName] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](1000) NOT NULL,
	[Type] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 4/28/2023 10:57:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[DateCheckIn] [date] NOT NULL,
	[DateCheckOut] [date] NULL,
	[idTable] [int] NOT NULL,
	[status] [int] NOT NULL,
	[discount] [int] NULL,
	[totalMoney] [float] NULL,
 CONSTRAINT [PK__Bill__3213E83F94853CCB] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillInfo]    Script Date: 4/28/2023 10:57:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillInfo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idBill] [int] NOT NULL,
	[idFood] [int] NOT NULL,
	[count] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Food]    Script Date: 4/28/2023 10:57:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[idCategory] [int] NOT NULL,
	[price] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FoodCategory]    Script Date: 4/28/2023 10:57:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodCategory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TableFood]    Script Date: 4/28/2023 10:57:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableFood](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[status] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([Username], [DisplayName], [Password], [Type]) VALUES (N' ,?b?Y[?K-#Kp', N'demone', N' ,?b?Y[?K-#Kp', 1)
INSERT [dbo].[Account] ([Username], [DisplayName], [Password], [Type]) VALUES (N'!#/)zW??C?JJ??', N'admin(1)', N'??B8??#??P?ou??', 1)
INSERT [dbo].[Account] ([Username], [DisplayName], [Password], [Type]) VALUES (N'????R????#?', N'user(1)', N'??B8??#??P?ou??', 0)
INSERT [dbo].[Account] ([Username], [DisplayName], [Password], [Type]) VALUES (N'??B8??#??P?ou??', N'tests', N' ,?b?Y[?K-#Kp', 0)
GO
SET IDENTITY_INSERT [dbo].[Food] ON 

INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (1, N'Ech Chien Nuoc Mam', 1, 100)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (2, N'Com Chien Duong Chau', 2, 100)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (3, N'Oc Luoc Siu Ngon', 1, 120)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (4, N'Ca Loc Nuong', 2, 110)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (5, N'Dau Hu Chien Don', 3, 320)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (6, N'Com Tam Da', 4, 220)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (7, N'Beefsteak', 1, 140)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (8, N'Du De Nuong', 2, 130)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (9, N'Bun Thit Nuong', 3, 720)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (10, N'Lau Thai', 4, 170)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (11, N'Hen Xuc Banh Da', 1, 320)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (12, N'Ca Trung Nuong', 2, 170)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (13, N'Mi Xao Hai San', 3, 140)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (14, N'Ngoc Trinh', 4, 190)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (15, N'Tiger Nau', 5, 20)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (16, N'Tiger Bac', 5, 70)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (17, N'Saigon', 5, 20)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (18, N'Lac Viet', 5, 70)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (19, N'Heniken', 5, 40)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (20, N'333', 5, 90)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (22, N'Dai Bang Mau Vang', 3, 600)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (23, N'Ca Loc Canh Cua', 2, 110)
SET IDENTITY_INSERT [dbo].[Food] OFF
GO
SET IDENTITY_INSERT [dbo].[FoodCategory] ON 

INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (1, N'Song Nuoc')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (2, N'Hai San')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (3, N'Rung Ram')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (4, N'Pho Bien')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (5, N'Thuc Uong')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (6, N'Dac Biet')
SET IDENTITY_INSERT [dbo].[FoodCategory] OFF
GO
SET IDENTITY_INSERT [dbo].[TableFood] ON 

INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (1, N'Table 0', N'No Body')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (2, N'Table 1', N'No Body')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (3, N'Table 2', N'No Body')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (4, N'Table 3', N'No Body')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (5, N'Table 4', N'No Body')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (6, N'Table 5', N'No Body')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (7, N'Table 6', N'No Body')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (8, N'Table 7', N'No Body')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (9, N'Table 8', N'No Body')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (10, N'Table 9', N'No Body')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (15, N'Table 10', N'No Body')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (16, N'Table 11', N'No Body')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (17, N'Table 12', N'No Body')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (18, N'Table 13', N'No Body')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (19, N'Table 14', N'No Body')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (20, N'Table 15', N'No Body')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (21, N'Table 16', N'No Body')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (22, N'Table 17', N'No Body')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (23, N'Table 18', N'No Body')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (24, N'Table 19', N'No Body')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (35, N'Table 20', N'No Body')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (36, N'Table 21', N'No Body')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (37, N'Table 22', N'No Body')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (38, N'Table 23', N'No Body')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (39, N'Table 24', N'No Body')
SET IDENTITY_INSERT [dbo].[TableFood] OFF
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT (N'Real Club') FOR [DisplayName]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT ((0)) FOR [Password]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT ((0)) FOR [Type]
GO
ALTER TABLE [dbo].[Bill] ADD  CONSTRAINT [DF__Bill__DateCheckI__34C8D9D1]  DEFAULT (getdate()) FOR [DateCheckIn]
GO
ALTER TABLE [dbo].[Bill] ADD  CONSTRAINT [DF__Bill__status__35BCFE0A]  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[BillInfo] ADD  DEFAULT ((0)) FOR [count]
GO
ALTER TABLE [dbo].[Food] ADD  DEFAULT (N'No Name') FOR [name]
GO
ALTER TABLE [dbo].[Food] ADD  DEFAULT ((0)) FOR [price]
GO
ALTER TABLE [dbo].[FoodCategory] ADD  DEFAULT (N'No Name') FOR [name]
GO
ALTER TABLE [dbo].[TableFood] ADD  DEFAULT (N'No Name') FOR [name]
GO
ALTER TABLE [dbo].[TableFood] ADD  DEFAULT (N'No Body') FOR [status]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK__Bill__status__36B12243] FOREIGN KEY([idTable])
REFERENCES [dbo].[TableFood] ([id])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK__Bill__status__36B12243]
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD  CONSTRAINT [FK__BillInfo__count__3A81B327] FOREIGN KEY([idBill])
REFERENCES [dbo].[Bill] ([id])
GO
ALTER TABLE [dbo].[BillInfo] CHECK CONSTRAINT [FK__BillInfo__count__3A81B327]
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD FOREIGN KEY([idFood])
REFERENCES [dbo].[Food] ([id])
GO
ALTER TABLE [dbo].[Food]  WITH CHECK ADD FOREIGN KEY([idCategory])
REFERENCES [dbo].[FoodCategory] ([id])
GO
/****** Object:  StoredProcedure [dbo].[USP_ChangeName]    Script Date: 4/28/2023 10:57:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_ChangeName]
@displayName nvarchar(100), @username nvarchar(100), @password nvarchar(100)
as
begin
	update Account set DisplayName=@displayName where Username=@username and Password=@password
end
GO
/****** Object:  StoredProcedure [dbo].[USP_ChangePassword]    Script Date: 4/28/2023 10:57:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_ChangePassword]
 @newPassword  nvarchar(100), @username nvarchar(100), @oldPassword nvarchar(100)
as
begin
	update account set Password=@newPassword where Username=@username and Password=@oldPassword
end
GO
/****** Object:  StoredProcedure [dbo].[USP_ChangeTable]    Script Date: 4/28/2023 10:57:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[USP_ChangeTable]
@idTableOld int, @idTableNew int, @idBillOld int, @idBillNew int
as 
begin
	declare @existStatus int	
	select @existStatus=TableFood.id from TableFood where TableFood.id=@idTableNew and status=N'No Body'
	if(@existStatus >0)
	begin
		update TableFood set status =N'No Body'	where TableFood.id=@idTableOld
		update TableFood set status=N'Active' where TableFood.id=@idTableNew
		update Bill set idTable=@idTableNew where idTable=@idTableOld
	end
	else
	begin
		update Bill set idTable=@idTableNew where id=@idBillOld and status =0 
		update Bill set idTable=@idTableOld where id=@idBillNew and status =0
	end
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetAccountByUsername]    Script Date: 4/28/2023 10:57:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_GetAccountByUsername]
@Username nvarchar(100)
as
begin
select * from account where Account.Username=@Username
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListFoodIdCate]    Script Date: 4/28/2023 10:57:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_GetListFoodIdCate]
@idCategory int
as
begin 
	select * from Food where idCategory=@idCategory ;
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetTableList]    Script Date: 4/28/2023 10:57:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_GetTableList]
as
begin
	select * from TableFood;
end
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBillInfo]    Script Date: 4/28/2023 10:57:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[USP_InsertBillInfo]
@idBill int, @idFood int, @count int
as
begin 
	declare @isExitFood int;
	declare @foodCount int;
	select  @isExitFood= BillInfo.id, @foodCount=BillInfo.count from BillInfo where idBill=@idBill and idFood=@idFood;
	if(@isExitFood>0)
	begin
		declare @quantity int =@count+@foodCount
		if(@quantity >0)
			update BillInfo  set BillInfo.count=@count+@foodCount where BillInfo.idBill=@idBill and BillInfo.idFood=@idFood 
		else
			delete BillInfo where BillInfo.idBill=@idBill and BillInfo.idFood=@idFood 
	end
	else
	begin
		insert into BillInfo (idBill, idFood, count) values(@idBill,@idFood,@count)
	end 
end
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertNewBill]    Script Date: 4/28/2023 10:57:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_InsertNewBill]
@idTable int, @discount int
as 
begin
insert into Bill (DateCheckIn,DateCheckOut, idTable, status,discount) values(GETDATE(),null, @idTable,0,0)
end
GO
/****** Object:  StoredProcedure [dbo].[USP_Login]    Script Date: 4/28/2023 10:57:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_Login]
@Username nvarchar(100),
@Password nvarchar(100)
as 
begin
select * from account where username=@Username and password=@Password
end
GO
/****** Object:  StoredProcedure [dbo].[USP_PaymentBill]    Script Date: 4/28/2023 10:57:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE proc [dbo].[USP_PaymentBill]
@id int, @discount int, @totalMoney float
as 
begin
	update Bill set status =1, DateCheckOut=GETDATE(), discount=@discount, totalMoney=@totalMoney where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateStatusTable]    Script Date: 4/28/2023 10:57:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_UpdateStatusTable]
@id int, @status nvarchar(100)
as
begin 
	update TableFood set status=@status where id=@id
end
GO
