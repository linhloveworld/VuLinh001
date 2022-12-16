USE BTL_NET1_QLThuVien
GO
--TAO KHOA NGOAI PRIMARYKEY
GO
ALTER TABLE SACHMUON ADD CONSTRAINT FRK_SACHMUON_PHIEUMUON FOREIGN KEY(MaPhieuMuon) REFERENCES PHIEUMUON(MaPhieuMuon)
ALTER TABLE SACHMUON ADD CONSTRAINT FRK_SACHMUON_SACH FOREIGN KEY (MaSach) REFERENCES SACH(MaSach)

ALTER TABLE PHIEUNHACTRA ADD CONSTRAINT FRK_PHIEUNHACTRA_NHANVIEN FOREIGN KEY (MaNhanVien) REFERENCES NHANVIEN(MaNhanVien)
ALTER TABLE PHIEUNHACTRA ADD CONSTRAINT FRK_PHIEUNHACTRA_SACH FOREIGN KEY (MaSach) REFERENCES SACH(MaSach)
ALTER TABLE PHIEUNHACTRA ADD CONSTRAINT FRK_PHIEUNHACTRA_THETHUVIEN FOREIGN KEY (MaThe) REFERENCES THETHUVIEN(MaThe)

ALTER TABLE PHIEUMUON ADD CONSTRAINT FRK_PHIEUMUON_SACH FOREIGN KEY (MaSach) REFERENCES SACH(MaSach)
ALTER TABLE PHIEUMUON ADD CONSTRAINT FRK_PHIEUMUON_THETHUVIEN FOREIGN KEY (MaThe) REFERENCES THETHUVIEN(MaThe)

alter table SACH add constraint def_SACH_SoLuong check(SoLuong>0)
alter table NHANVIEN add constraint unq_NHANVIEN_TenNV_DiaChiNV unique(TenNV,DiaChiNV),
constraint def_NHANVIEN_NgaySinh default(getdate()) for NgaySinh,
constraint def_NHANVIEN_NgayVaoLam default(getdate()) for NgayVaoLam,
constraint def_NHANVIEN_SoDienThoaiNV default(N'Chua co') for SoDienThoaiNV

alter table THETHUVIEN ADD CONSTRAINT UNQ_THETHUVIEN_TenSV unique(TenSV,DiaChiSV),
	constraint def_THETHUVIEN_NgayTaoThe DEFAULT(GETDATE()) for NgayTaoThe,
	constraint def_THETHUVIEN_NgayTheHetHan default(getdate()) for NgayTheHetHan,
	constraint def_THETHUVIEN_NgaySinh default(getdate()) for NgaySinh,
	constraint def_THETHUVIEN_SoDienThoaiSV default(getdate()) for SoDienThoaiSV

alter table SACHMUON ADD
	CONSTRAINT ckh_SACHMUON_SoLuongSachMuon check(SoLuongSachMuon>0),
	constraint def_SACHMUON_NgayTra default(getupdate()) for NgayTra

alter table PHIEUNHACTRA add CONSTRAINT CHK_PHIEUNHACTRA_NgayLapThe default (getdate()) for NgayLapThe,
constraint ckh_PHIEUNHACTRA_DonGiaPhat check(DonGiaPhat>=0)

alter table PHIEUMUON add constraint chk_PHIEUMUON_NgayMuon default(getdate()) for NgayMuon
go
use BTL_NET1_QLThuVien
go

CREATE PROC sp_LOADSACH
AS
	BEGIN
		SELECT * FROM SACH
	END

