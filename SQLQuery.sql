-- Tạo bảng Quạt Máy
CREATE TABLE QuatMay (
    MaQuat VARCHAR(10) PRIMARY KEY,
    LoaiQuat VARCHAR(255),
    TenQuat VARCHAR(255),
    CongSuat INT,
    DienAp INT,
    ThoiGianBaoHanh INT
);

-- Chèn dữ liệu mẫu vào bảng Quạt Máy
INSERT INTO QuatMay (MaQuat, LoaiQuat, TenQuat, CongSuat, DienAp, ThoiGianBaoHanh) VALUES
('QM001', 'Quạt trần', 'Quạt trần Panasonic', 75, 220, 24),
('QM002', 'Quạt bàn', 'Quạt bàn Senko', 45, 220, 12),
('QM003', 'Quạt đứng', 'Quạt đứng Mitsubishi', 55, 220, 18);

-- Tạo bảng Xưởng Lắp Ráp
CREATE TABLE XuongLapRap (
    MaXuong VARCHAR(10) PRIMARY KEY,
    SoDienThoai VARCHAR(50),
    LoaiQuatLapRap VARCHAR(255)
);

-- Chèn dữ liệu mẫu vào bảng Xưởng Lắp Ráp
INSERT INTO XuongLapRap (MaXuong, SoDienThoai, LoaiQuatLapRap) VALUES
('XLR001', '0123456789', 'Quạt trần'),
('XLR002', '0987654321', 'Quạt bàn'),
('XLR003', '1234567890', 'Quạt đứng');

-- Tạo bảng Nhân Viên
CREATE TABLE NhanVien (
    MaNhanVien VARCHAR(10) PRIMARY KEY,
    TenNhanVien VARCHAR(255),
    SoDienThoai VARCHAR(50),
    ChucVu VARCHAR(255)
);

-- Chèn dữ liệu mẫu vào bảng Nhân Viên
INSERT INTO NhanVien (MaNhanVien, TenNhanVien, SoDienThoai, ChucVu) VALUES
('NV001', 'Nguyễn Văn A', '0912345678', 'Quản lý'),
('NV002', 'Trần Thị B', '0987654321', 'Nhân viên kho xuất'),
('NV003', 'Lê Văn C', '0901234567', 'Nhân viên kho nhập');


-- Tạo bảng Phiếu Nhập Kho
CREATE TABLE PhieuNhapKho (
    MaPhieuNhap VARCHAR(10) PRIMARY KEY,
    MaXuong VARCHAR(10),
    NguoiGiao VARCHAR(255),
    MaQuat VARCHAR(10),
    SoLuong INT,
    NgayNhapKho DATE,
    MaNhanVien VARCHAR(10),
    FOREIGN KEY (MaXuong) REFERENCES XuongLapRap(MaXuong),
    FOREIGN KEY (MaQuat) REFERENCES QuatMay(MaQuat),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);

-- Chèn dữ liệu mẫu vào bảng Phiếu Nhập Kho
INSERT INTO PhieuNhapKho (MaPhieuNhap, MaXuong, NguoiGiao, MaQuat, SoLuong, NgayNhapKho, MaNhanVien) VALUES
('PNK001', 'XLR001', 'Nguyễn Văn D', 'QM001', 50, '2024-05-01', 'NV002'),
('PNK002', 'XLR002', 'Trần Thị E', 'QM002', 30, '2024-05-02', 'NV002'),
('PNK003', 'XLR003', 'Lê Văn F', 'QM003', 40, '2024-05-03', 'NV002');


-- Tạo bảng Kho
CREATE TABLE Kho (
    MaQuat VARCHAR(10) PRIMARY KEY,
    SoLuongTon INT,
    FOREIGN KEY (MaQuat) REFERENCES QuatMay(MaQuat)
);

-- Chèn dữ liệu mẫu vào bảng Kho
INSERT INTO Kho (MaQuat, SoLuongTon) VALUES
('QM001', 50),
('QM002', 30),
('QM003', 40);

-- Tạo bảng Đại Lý
CREATE TABLE DaiLy (
    MaDaiLy VARCHAR(10) PRIMARY KEY,
    TenDaiLy VARCHAR(255),
    MaSoThue VARCHAR(50),
    DiaChi VARCHAR(255),
    DienThoai VARCHAR(50),
    TenGiamDoc VARCHAR(255),
    TenNguoiLienLac VARCHAR(255),
    SoDienThoaiNguoiLienLac VARCHAR(50),
    MucUuTien INT
);

-- Chèn dữ liệu mẫu vào bảng Đại Lý
INSERT INTO DaiLy (MaDaiLy, TenDaiLy, MaSoThue, DiaChi, DienThoai, TenGiamDoc, TenNguoiLienLac, SoDienThoaiNguoiLienLac, MucUuTien) VALUES
('DL001', 'Đại lý A', '123456789', '123 Đường A, Quận 1, TP.HCM', '0912345678', 'Nguyễn Văn G', 'Nguyễn Văn H', '0912345679', 10),
('DL002', 'Đại lý B', '987654321', '456 Đường B, Quận 2, TP.HCM', '0987654321', 'Trần Thị I', 'Trần Thị K', '0987654322', 15);


-- Tạo bảng Phiếu xuất
CREATE TABLE PhieuXuatKho (
    MaGiaoDich INT PRIMARY KEY,
    MaDaiLy VARCHAR(10),
    MaQuat VARCHAR(10),
    DonGia DECIMAL(10, 2),
    SoLuongXuat INT,
    ThanhTien DECIMAL(10, 2),
    NgayGiaoDich DATE,
    NguoiLapPhieu VARCHAR(255),
    NguoiNhan VARCHAR(255),
    ChuKyThuTruong VARCHAR(255),
    NgayPhatHanh DATE,
    SoHieuPhieu VARCHAR(50),
    BoCongNghiep VARCHAR(255),
    MaNhanVien VARCHAR(10),
    FOREIGN KEY (MaDaiLy) REFERENCES DaiLy(MaDaiLy),
    FOREIGN KEY (MaQuat) REFERENCES QuatMay(MaQuat),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);

-- Chèn dữ liệu mẫu vào bảng Phiếu xuất
INSERT INTO PhieuXuatKho (MaGiaoDich, MaDaiLy, MaQuat, DonGia, SoLuongXuat, ThanhTien, NgayGiaoDich, NguoiLapPhieu, NguoiNhan, ChuKyThuTruong, NgayPhatHanh, SoHieuPhieu, BoCongNghiep, MaNhanVien) VALUES
(1, 'DL001', 'QM001', 500000.00, 10, 5000000.00, '2024-05-10', 'Nguyễn Văn A', 'Nguyễn Văn H', 'Chu Ký A', '2024-05-10', 'PH001', 'Bộ Công Thương', 'NV003'),
(2, 'DL002', 'QM002', 300000.00, 5, 1500000.00, '2024-05-11', 'Nguyễn Văn A', 'Trần Thị K', 'Chu Ký B', '2024-05-11', 'PH002', 'Bộ Công Thương', 'NV003');


-- Tạo bảng Công Nợ Đại Lý
CREATE TABLE CongNoDaiLy (
    MaDaiLy VARCHAR(10) PRIMARY KEY,
    TongHangDaLay INT,
    TongTienDaTra DECIMAL(10, 2),
    TongNo DECIMAL(10, 2),
    FOREIGN KEY (MaDaiLy) REFERENCES DaiLy(MaDaiLy)
);

-- Chèn dữ liệu mẫu vào bảng Công Nợ Đại Lý
INSERT INTO CongNoDaiLy (MaDaiLy, TongHangDaLay, TongTienDaTra, TongNo) VALUES
('DL001', 10, 3000000.00, 2000000.00),
('DL002', 5, 1500000.00, 0.00);


-- Tạo bảng Báo Cáo Sản Xuất
CREATE TABLE BaoCaoSanXuat (
    MaBaoCao INT PRIMARY KEY,
    Thang INT,
    MaQuat VARCHAR(10),
    SoLuongTon INT,
    NgayLapBaoCao DATE,
    FOREIGN KEY (MaQuat) REFERENCES QuatMay(MaQuat)
);

-- Chèn dữ liệu mẫu vào bảng Báo Cáo Sản Xuất
INSERT INTO BaoCaoSanXuat (MaBaoCao, Thang, MaQuat, SoLuongTon, NgayLapBaoCao) VALUES
(1, 5, 'QM001', 40, '2024-05-15'),
(2, 5, 'QM002', 25, '2024-05-15'),
(3, 5, 'QM003', 35, '2024-05-15');


-- Tạo bảng Phân Quyền
CREATE TABLE PhanQuyen (
    MaQuyen VARCHAR(10) PRIMARY KEY,
    TenQuyen VARCHAR(255)
);

INSERT INTO PhanQuyen (MaQuyen, TenQuyen) VALUES
('Q001', 'Quản lý'),
('Q002', 'Nhân viên kho xuất'),
('Q003', 'Nhân viên kho nhập');


-- Tạo bảng Quyền Nhân Viên
CREATE TABLE QuyenNhanVien (
    MaNhanVien VARCHAR(10),
    MaQuyen VARCHAR(10),
    PRIMARY KEY (MaNhanVien, MaQuyen),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien),
    FOREIGN KEY (MaQuyen) REFERENCES PhanQuyen(MaQuyen)
);

-- Chèn dữ liệu mẫu vào bảng Quyền Nhân Viên
INSERT INTO QuyenNhanVien (MaNhanVien, MaQuyen) VALUES
('NV001', 'Q001'),
('NV002', 'Q002'),
('NV003', 'Q003');