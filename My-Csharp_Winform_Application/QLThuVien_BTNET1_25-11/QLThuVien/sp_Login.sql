create proc [dbo].[SP_Login]
@TenDangNhap nvarchar(20),
@MatKhau nvarchar(20),
@TenQuyenHan text,
@MaNhanVien int
as
begin
    if exists (select * from Taikhoan where TenDangNhap = @TenDangNhap and MatKhau = @MatKhau and @TenQuyenHan = "member")
        select 1 as code
    else if exists (select * from Taikhoan where TenDangNhap = @TenDangNhap and MatKhau = @MatKhau and @TenQuyenHan = "admin")
        select 0 as code
    else if exists(select * from Taikhoan where TenDangNhap = @TenDangNhap and MatKhau = @MatKhau and @TenQuyenHan = "moderator")
        select 2 as code
    else if exists(select * from Taikhoan where TenDangNhap = @TenDangNhap and MatKhau != @MatKhau)
         select 3 as code
    else select 4 as code
end