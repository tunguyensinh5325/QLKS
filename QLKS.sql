create database QLKS

use QLKS

create table Phong(
	MaPhong char(5) primary key,
	LoaiPhong nvarchar(20), --('Phòng đơn', 'Phòng đôi', 'Phòng lớn')),
	TinhTrang nvarchar(10), --('Đã thuê', 'Trống')),
	Gia int,
	GhiChu nvarchar(100)
	
);
go

create table KhachHang (
	CMND char(15) primary key,
	TenKH nvarchar(20),
	LoaiKH nvarchar (15), --('Nội địa', 'Nước ngoài')),
	DiaChi nvarchar(50)
)

go

create table Thue(
	MaPhong char(5),
	CMND char(15),
	NgayDat datetime,
	NgayTra datetime,
	FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong),
    FOREIGN KEY (CMND) REFERENCES KhachHang(CMND)
)
go

create table HoaDon(
	MaHD varchar(20) primary key, --(MaPhong-ngày đặt)
	ThanhTien int,
	NgayDat datetime,
	NgayTra datetime,
	CMND char(15), -- Chủ phòng (chọn người thanh toán làm chủ)
	MaPhong char(5), 
	FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong),
    FOREIGN KEY (CMND) REFERENCES KhachHang(CMND)
)
go

create table BaoCao(
	MaHD varchar(20),
	MaPhong char(5),
	LoaiPhong nvarchar(20),
	SoNgay smallint,
	DoanhThu int,
	FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong),
    FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD),
	primary key (MaPhong, MaHD)
)
go
INSERT INTO Phong (MaPhong, LoaiPhong, TinhTrang, Gia, GhiChu)
VALUES 
('P001', N'Phòng lớn', N'Đã thuê', 200000, N'Có ban công'),
('P002', N'Phòng lớn', N'Đã thuê', 200000, N'Hướng biển'),
('P003', N'Phòng đôi', N'Trống', 170000, N'VIP Suite'),
('P004', N'Phòng lớn', N'Trống', 200000, N'Ban công nhỏ'),
('P005', N'Phòng đơn', N'Đã thuê', 150000, N'Hướng phố'),
('P006', N'Phòng đơn', N'Trống', 150000, N'Phòng cách âm'),
('P007', N'Phòng lớn', N'Trống', 200000, N'Hướng núi'),
('P008', N'Phòng đơn', N'Đã thuê', 150000, N'Hướng vườn'),
('P009', N'Phòng đôi', N'Trống', 170000, N'Suite VIP'),
('P010', N'Phòng lớn', N'Trống', 200000, N'Hướng nội bộ'),
('P011', N'Phòng đơn', N'Trống', 150000, N'Có nhà bếp'),
('P012', N'Phòng đôi', N'Trống', 170000, N'Hướng biển xa'),
('P013', N'Phòng lớn', N'Trống', 200000, N'Phòng đôi lớn')
INSERT INTO KhachHang (CMND, TenKH, LoaiKH, DiaChi)
VALUES
('123456789', N'Nguyen Van A', N'Nội địa', N'Hà Nội'),
('223456789', N'Tran Thi B', N'Nội địa', N'HCM'),
('323456789', N'Le Van C', N'Nước ngoài', N'USA'),
('423456789', N'Pham Thi D', N'Nội địa', N'Hải Phòng'),
('523456789', N'Hoang Van E', N'Nước ngoài', N'Canada'),
('623456789', N'Do Thi F', N'Nội địa', N'Da Nang'),
('723456789', N'Ly Van G', N'Nước ngoài', N'Australia'),
('823456789', N'Nguyen Thi H', N'Nội địa', N'Nha Trang'),
('923456789', N'Truong Van I', N'Nội địa', N'Vũng Tàu'),
('033456789', N'Vu Thi K', N'Nước ngoài', N'Japan')

INSERT INTO Thue (MaPhong, CMND, NgayDat, NgayTra)
VALUES
('P001', '123456789', '2024-06-05', '2024-06-010'),
--Phòng P001 - Phòng lớn, đã thanh toán
('P001', '123456789', '2024-06-01', '2024-06-04'),
('P001', '223456789', '2024-06-01', '2024-06-04'),
('P001', '423456789', '2024-06-01', '2024-06-04'),
--Phòng P002 - Phòng lớn
('P002', '223456789', '2024-06-06', '2024-06-010'),
('P002', '823456789', '2024-06-06', '2024-06-010'),
--Phòng P003 - Phòng đôi, đã thanh toán
('P003', '323456789', '2024-06-12', '2024-06-15'),
('P003', '123456789', '2024-06-12', '2024-06-15'),
('P003', '723456789', '2024-06-12', '2024-06-15'),
--Phòng P005 - Phòng đơn
('P005', '523456789', '2024-06-05', '2024-06-08'),
('P005', '923456789', '2024-06-05', '2024-06-08'),
('P005', '033456789', '2024-06-05', '2024-06-08'),

('P004', '423456789', '2024-06-04', '2024-06-07');

INSERT INTO HoaDon (MaHD, ThanhTien, NgayDat, NgayTra, CMND, MaPhong)
VALUES 
('P001-240601', 600000, '2024-06-01', '2024-06-04', '123456789', 'P001'),
('P003-240612', 900000, '2024-06-12', '2024-06-15', '123456789', 'P003')

INSERT INTO BaoCao (MaHD, MaPhong, LoaiPhong, SoNgay, DoanhThu)
VALUES 
('P001-240601', 'P001', N'Phòng lớn', 3, 600000),
('P003-240612', 'P003', N'Phòng lớn', 3, 900000);

select * from Phong
select * from KhachHang
select * from Thue
select * from HoaDon
select * from BaoCao

