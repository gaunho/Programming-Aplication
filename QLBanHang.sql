CREATE DATABASE QLBANHANG

CREATE TABLE [BAN]
(
	[MABAN] char(8) NOT NULL PRIMARY KEY ([MABAN]),
	[TENBAN] nvarchar(15) NOT NULL, 
	[TINHTRANG] nvarchar(5)
)


CREATE TABLE [USER]
(
	[ID] nvarchar(8) NOT NULL PRIMARY KEY ([ID]),
	[USERNAME] char(20) NOT NULL,
	[PASSWORD] char(20) NOT NULL,
	[LOAI] nvarchar(10)
)

CREATE TABLE [FOOD]
(
	[MASANPHAM] nvarchar(15) NOT NULL PRIMARY KEY ([MASANPHAM]),
	[TENSANPHAM] nvarchar(30) NOT NULL,
	[DONGIA] float,
	[TINHTRANG] nvarchar(10),
)

CREATE TABLE [HOADON]
(
	[MAHOADON] nvarchar(15) NOT NULL PRIMARY KEY ([MAHOADON]),
	[ID] nvarchar(8) NOT NULL FOREIGN KEY ([ID]) REFERENCES [USER]([ID]),
	[MASANPHAM] nvarchar(15) NOT NULL FOREIGN KEY ([MASANPHAM]) REFERENCES [FOOD]([MASANPHAM]),
	[MABAN] char(8) NOT NULL FOREIGN KEY ([MABAN]) REFERENCES [BAN]([MABAN]),
	[SOLUONG] int,
	[TONGTIEN] float,
	[NGAYXUATHOADON] Date,
)



INSERT INTO [BAN]
VALUES ('B001', 'BÀN 1', 'Trống'),
('B002', 'BÀN 2', 'Trống'),
('B003', 'BÀN 3', 'Trống'),
('B004', 'BÀN 4', 'Trống'),
('B005', 'BÀN 5', 'Trống'),
('B006', 'BÀN 6', 'Trống'),
('B007', 'BÀN 7', 'Trống'),
('B008', 'BÀN 8', 'Trống'),
('B009', 'BÀN 9', 'Trống'),
('B0010', 'BÀN 10', 'Trống'),
('B0011', 'BÀN 11', 'Trống'),
('B0012', 'BÀN 12', 'Trống'),
('V001', 'BÀN VIP 1', 'Trống'),
('V002', 'BÀN VIP 2', 'Trống'),
('V003', 'BÀN VIP 3', 'Trống'),
('V004', 'BÀN VIP 4', 'Trống'),
('V005', 'BÀN VIP 5', 'Trống'),
('V006', 'BÀN VIP 6', 'Trống'),
('V007', 'BÀN VIP 7', 'Trống'),
('V008', 'BÀN VIP 8', 'Trống')

INSERT INTO [USER]
VALUES ('admin', 'admin', 'admin','admin'),
('NV001', 'NGOCPHUONG', 'ngocphuong', 'user'),
('NV002', 'NHUNGOC', 'nhungoc', 'user'),
('NV003', 'VANHIEU', 'vanhieu', 'user')

INSERT INTO [FOOD]
VALUES ('F001', 'Lẩu Gà', 200000, 'Còn'),
('F002', 'Lẩu Tôm Hùm', 300000, 'Còn'),
('F003', 'Lẩu Thái Hải Sản', 260000, 'Còn'),
('F004', 'Lẩu Mắm Nam Bộ', 349000, 'Còn'),
('F005', 'Lẩu Thái', 260000, 'Còn'),
('F006', 'Cơm Chiên Hải Sản', 99000, 'Còn'),
('F007', 'Cơm Chiên Cá Mặn', 99000, 'Còn'),
('F008', 'Cơm Chiên Dương Châu', 99000, 'Còn'),
('F009', 'Cơm Chiên Dưa Bò', 99000, 'Còn'),
('F010', 'Cơm Chiên Trái Thơm', 129000, 'Còn'),
('F011', 'Mì Xào Hải Sản', 99000, 'Còn'),
('F012', 'Mì Xào Bò', 109000, 'Còn'),
('F013', 'Mì Xào Rau', 69000, 'Còn'),
('F014', 'Rau Luộc TC Kho Quẹt', 87000, 'Còn'),
('F015', 'Rau Luộc TC', 79000, 'Còn'),
('F016', 'Rau Rừng Luộc', 87000, 'Còn'),
('F017', 'Rau Muống Luộc', 87000, 'Còn'),
('F018', 'Rau Muống Xào Tỏi', 89000, 'Còn'),
('F019', 'Cần Nước Xào Tỏi', 89000, 'Còn'),
('F020', 'Rau Lang Xào Tỏi', 89000, 'Còn'),
('F021', 'Gỏi Bò WASABI', 109000, 'Còn'),
('F022', 'Gỏi Ngó Sen Tôm Thịt', 109000, 'Còn'),
('F023', 'Gỏi Củ Hủ Dừa Tôm Thịt', 109000, 'Còn'),
('F024', 'Gỏi Hải Sản Khoai Môn', 109000, 'Còn'),
('F025', 'Tôm Càng Xanh', 350000, 'Còn'),
('F026', 'Tôm Sú Biển', 550000, 'Còn'),
('F027', 'Cá Hồng Vĩ', 445000, 'Còn'),
('F028', 'Cá Thờn Bơn', 600000, 'Còn'),
('F029', 'Cá Tầm', 245000, 'Còn'),
('F030', 'Tôm Hùm Alaska', 645000, 'Còn'),
('F031', 'Tôm Hùm Baby', 700000, 'Còn'),
('F032', 'Dúi', 1390000, 'Còn'),
('F033', 'Chồn', 2450000, 'Còn'),
('F034', 'Cá Mặt Qủy', 690000, 'Còn'),


('D001', 'Sting', 15000, 'Còn'),
('D002', 'CoCa', 15000, 'Còn'),
('D003', '7 up', 15000, 'Còn'),
('D004', 'Pepsi', 15000, 'Còn'),
('D005', 'Suối', 15000, 'Còn'),
('D006', 'Soda Chanh', 15000, 'Còn'),
('D007', 'Soda', 15000, 'Còn'),
('D008', 'Vang Ý', 650000, 'Còn'),
('D009', 'Vang 1918 Classic', 690000, 'Còn'),
('D010', 'Vang Apu', 490000, 'Còn'),
('D011', 'Vang Chile Đỏ', 690000, 'Còn'),
('D012', 'Macallan', 2700000, 'Còn'),
('D013', 'Tiger Nâu Lon', 23000, 'Còn'),
('D014', 'Heineken lon', 23000, 'Còn'),
('D015', 'Heineken Pháp Chai', 39000, 'Còn')


INSERT INTO [HOADON]
VALUES ('HD001', 'NV001', 'F001', 'B001', 2, 400000, '11/17/2018')

