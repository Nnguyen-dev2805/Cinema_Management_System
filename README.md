# StarCinema - Hệ Thống Quản Lý Rạp Chiếu Phim

![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2-512BD4?style=flat-square&logo=.net)
![C#](https://img.shields.io/badge/C%23-239120?style=flat-square&logo=c-sharp&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-0078D6?style=flat-square&logo=windows&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?style=flat-square&logo=microsoft-sql-server&logoColor=white)
![License](https://img.shields.io/badge/License-MIT-green?style=flat-square)

## Giới Thiệu

**StarCinema** là một hệ thống quản lý rạp chiếu phim toàn diện được phát triển bằng C# Windows Forms, cung cấp giải pháp hoàn chỉnh cho việc vận hành và quản lý các hoạt động của rạp chiếu phim hiện đại. Hệ thống được thiết kế với giao diện trực quan, dễ sử dụng và tích hợp đầy đủ các chức năng cần thiết từ quản lý phim, lịch chiếu, bán vé đến quản lý nhân viên và thống kê doanh thu.

## Mục Lục

- [Tính Năng Chính](#tính-năng-chính)
- [Công Nghệ Sử Dụng](#công-nghệ-sử-dụng)
- [Yêu Cầu Hệ Thống](#yêu-cầu-hệ-thống)
- [Cài Đặt](#cài-đặt)
- [Cấu Trúc Dự Án](#cấu-trúc-dự-án)
- [Hướng Dẫn Sử Dụng](#hướng-dẫn-sử-dụng)
- [Nhóm Phát Triển](#nhóm-phát-triển)
- [Giấy Phép](#giấy-phép)

## Tính Năng Chính

### Quản Lý Phim
- Thêm, sửa, xóa thông tin phim
- Quản lý chi tiết phim (tên, thể loại, thời lượng, đạo diễn, diễn viên, mô tả, poster)
- Tìm kiếm và lọc phim theo nhiều tiêu chí
- Quản lý trạng thái phim (đang chiếu, sắp chiếu, ngừng chiếu)
- Gia hạn thời gian chiếu phim

### Quản Lý Lịch Chiếu
- Tạo và quản lý lịch chiếu cho từng phim
- Quản lý phòng chiếu và ghế ngồi
- Xem lịch chiếu theo phim và theo ngày
- Đặt vé và chọn ghế trực quan
- In vé điện tử
- Quản lý đổi vé và hoàn tiền

### Quản Lý Khách Hàng
- Đăng ký thông tin khách hàng
- Cập nhật thông tin khách hàng
- Tra cứu lịch sử giao dịch
- Quản lý thành viên và điểm thưởng

### Quản Lý Sản Phẩm
- Quản lý sản phẩm bán kèm (bắp rang, nước uống, đồ ăn nhẹ)
- Nhập hàng và quản lý tồn kho
- Bán hàng và xuất hóa đơn
- In hóa đơn bán hàng (Crystal Reports)
- Theo dõi doanh thu từ sản phẩm

### Quản Lý Nhân Viên
- Thêm, sửa, xóa thông tin nhân viên
- Quản lý phân quyền và vai trò
- Tính lương và quản lý công
- Xem chi tiết thông tin nhân viên

### Thống Kê & Báo Cáo
- Thống kê doanh thu theo ngày, tháng, năm
- Báo cáo doanh thu theo phim
- Biểu đồ trực quan hóa dữ liệu
- Xuất báo cáo Excel (EPPlus, ClosedXML)
- Phân tích hiệu suất kinh doanh

### Xác Thực & Bảo Mật
- Đăng nhập với xác thực tài khoản
- Phân quyền theo vai trò (Admin, Nhân viên)
- Quên mật khẩu và khôi phục tài khoản
- Quản lý thông tin cá nhân

### Giao Diện & Trải Nghiệm
- Giao diện hiện đại với Guna UI2
- Thông báo và cảnh báo trực quan
- Hỗ trợ drag-and-drop
- Responsive và thân thiện người dùng

## Công Nghệ Sử Dụng

### Ngôn Ngữ & Framework
- **C#** - Ngôn ngữ lập trình chính
- **.NET Framework 4.7.2** - Nền tảng phát triển
- **Windows Forms** - Framework giao diện người dùng

### Cơ Sở Dữ Liệu
- **Microsoft SQL Server** - Hệ quản trị cơ sở dữ liệu
- **LINQ to SQL** - ORM để truy vấn dữ liệu
- **Microsoft.Data.SqlClient 5.1.6** - Provider kết nối SQL Server

### Thư Viện UI/UX
- **Guna.UI2.WinForms 2.0.4.7** - Thư viện UI components hiện đại
- **Microsoft.Web.WebView2** - Tích hợp web view

### Thư Viện Xử Lý Dữ Liệu
- **EPPlus 8.0.3** - Xuất/nhập file Excel
- **ClosedXML 0.104.2** - Thao tác với Excel
- **CsvHelper 33.0.1** - Xử lý file CSV
- **DocumentFormat.OpenXml 3.1.1** - Làm việc với Office documents

### Báo Cáo
- **Crystal Reports** - In ấn hóa đơn và báo cáo

### Bảo Mật & Xác Thực
- **Azure.Identity 1.11.4** - Xác thực Azure
- **Microsoft.Identity.Client 4.61.3** - MSAL authentication
- **System.IdentityModel.Tokens.Jwt 6.35.0** - JWT tokens

## Yêu Cầu Hệ Thống

### Phần Mềm
- **Hệ điều hành:** Windows 10/11
- **IDE:** Visual Studio 2019 hoặc mới hơn
- **.NET Framework:** 4.7.2 trở lên
- **SQL Server:** 2017 trở lên (Express/Standard/Enterprise)

### Phần Cứng (Khuyến nghị)
- **CPU:** Intel Core i5 hoặc tương đương
- **RAM:** 4GB trở lên
- **Ổ cứng:** 500MB dung lượng trống

## Cài Đặt

### Bước 1: Clone Repository

```bash
git clone https://github.com/yourusername/Cinema_Management_System.git
cd Cinema_Management_System
```

### Bước 2: Cài Đặt SQL Server

1. Cài đặt SQL Server (nếu chưa có)
2. Khôi phục database từ file backup:
   - Mở SQL Server Management Studio (SSMS)
   - Kết nối đến SQL Server
   - Right-click **Databases** > **Restore Database**
   - Chọn file: `backup_7_5_part2_2025.bak` hoặc `backup_5_5_2025.bak`

### Bước 3: Cấu Hình Connection String

Mở file `App.config` và cập nhật connection string:

```xml
<connectionStrings>
    <add name="Cinema_Management_System.Properties.Settings.CinemaManagementConnectionString" 
         connectionString="Data Source=YOUR_SERVER_NAME;Initial Catalog=CinemaManagement;Integrated Security=True;TrustServerCertificate=True" 
         providerName="System.Data.SqlClient" />
</connectionStrings>
```

Thay `YOUR_SERVER_NAME` bằng tên SQL Server của bạn (ví dụ: `.`, `localhost`, hoặc `DESKTOP-XXXXX`).

### Bước 4: Restore NuGet Packages

Trong Visual Studio:
1. Mở solution file: `Cinema_Management_System.sln`
2. Click chuột phải vào Solution > **Restore NuGet Packages**
3. Hoặc chạy lệnh: `dotnet restore` trong Terminal

### Bước 5: Build và Run

1. Trong Visual Studio: **Build** > **Build Solution** (Ctrl+Shift+B)
2. Nhấn **F5** để chạy ứng dụng
3. Đăng nhập với tài khoản mặc định (xem trong database)

## Cấu Trúc Dự Án

```
Cinema_Management_System/
├── Models/
│   ├── DAOs/                      # Data Access Objects
│   │   ├── Bills/                 # Quản lý hóa đơn
│   │   ├── AuditoriumDA.cs        # Phòng chiếu
│   │   ├── BillForShowTimeDA.cs   # Hóa đơn vé
│   │   ├── CustomerDA.cs          # Khách hàng
│   │   ├── MovieDA.cs             # Phim
│   │   ├── ProductDA.cs           # Sản phẩm
│   │   ├── ShowTimeDA.cs          # Lịch chiếu
│   │   ├── StaffDA.cs             # Nhân viên
│   │   └── UserDA.cs              # Người dùng
│   └── DTOs/                      # Data Transfer Objects
│       ├── ProductManagement/     # DTO sản phẩm
│       ├── BillAddMovieDTO.cs
│       ├── CustomerDTO.cs
│       ├── MovieDTO.cs
│       ├── ShowTimeDTO.cs
│       └── StaffDTO.cs
├── Views/
│   ├── AdminForm/                 # Giao diện Admin
│   ├── CustomerManagement/        # Quản lý khách hàng
│   ├── InformationManagement/     # Quản lý thông tin
│   ├── Login/                     # Đăng nhập
│   ├── MovieManagement/           # Quản lý phim
│   ├── ProductManagement/         # Quản lý sản phẩm
│   ├── ShowTimeManagement/        # Quản lý lịch chiếu
│   ├── StaffManagement/           # Quản lý nhân viên
│   └── Statistics/                # Thống kê
├── ViewModels/                    # Business Logic
│   ├── CustomerManagement/
│   ├── MovieManagementVM/
│   └── ShowTimeManagementVM/
├── Resources/                     # Tài nguyên (hình ảnh, icons)
├── App.config                     # Cấu hình ứng dụng
├── Program.cs                     # Entry point
└── Connect.dbml                   # LINQ to SQL mapping
```

## Hướng Dẫn Sử Dụng

### Đăng Nhập

1. Khởi động ứng dụng
2. Nhập tên đăng nhập và mật khẩu
3. Chọn vai trò (Admin/Nhân viên)
4. Click **Đăng nhập**

### Quản Lý Phim

1. Vào menu **Quản lý phim**
2. Click **Thêm phim mới** để thêm phim
3. Nhập đầy đủ thông tin: tên phim, thể loại, thời lượng, đạo diễn, v.v.
4. Upload poster phim
5. Click **Lưu**

### Tạo Lịch Chiếu

1. Vào **Quản lý lịch chiếu**
2. Chọn phim cần tạo lịch
3. Chọn phòng chiếu, ngày giờ
4. Thiết lập giá vé
5. Click **Tạo lịch chiếu**

### Bán Vé

1. Vào **Quản lý lịch chiếu**
2. Chọn suất chiếu
3. Chọn ghế ngồi trên sơ đồ phòng
4. Nhập thông tin khách hàng
5. Thanh toán và in vé

### Xuất Báo Cáo

1. Vào **Thống kê**
2. Chọn loại báo cáo (doanh thu, phim, sản phẩm)
3. Chọn khoảng thời gian
4. Click **Xem báo cáo** hoặc **Xuất Excel**

## Tính Năng Sắp Tới

- [ ] Tích hợp thanh toán online
- [ ] Ứng dụng mobile cho khách hàng
- [ ] API RESTful
- [ ] Dashboard analytics nâng cao
- [ ] Hệ thống đánh giá phim
- [ ] Tích hợp mạng xã hội

## Nhóm Phát Triển

Dự án được thực hiện bởi nhóm sinh viên:

| MSSV | Họ và Tên | GitHub | Vai Trò |
|------|-----------|--------|---------|
| 23110273 | Trương Nhất Nguyên | [@Nnguyen-dev2805](https://github.com/Nnguyen-dev2805) | Team Lead |
| 23110207 | Nguyễn Hoàng Hà | - | Developer |
| 23110222 | Nghiêm Quang Huy | [@HuyinCP](https://github.com/HuyinCP) | Developer |
| 23110304 | Đặng Ngọc Tài | - | Developer |
| 23110369 | Nguyễn Tấn Yên | - | Developer |

## Đóng Góp

Mọi đóng góp đều được chào đón! Vui lòng:

1. Fork repository
2. Tạo branch mới (`git checkout -b feature/AmazingFeature`)
3. Commit thay đổi (`git commit -m 'Add some AmazingFeature'`)
4. Push lên branch (`git push origin feature/AmazingFeature`)
5. Tạo Pull Request

## Giấy Phép

Dự án này được phân phối dưới giấy phép MIT. Xem file `LICENSE` để biết thêm chi tiết.

## Liên Hệ

Nếu có bất kỳ câu hỏi hoặc góp ý nào, vui lòng liên hệ:

- Email: [tnhatnguyen.dev2805@gmail.com](mailto:tnhatnguyen.dev2805@gmail.com)

---

**Lưu ý:** Dự án này được phát triển cho mục đích học tập và nghiên cứu.

Made by HCMUTE Student
