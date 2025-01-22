# BookStoreAPI
API RESTful giúp quản lý sách trong một của hàng sáng, được xây dựng bằng ASP.NET Core. API này cho phép thực hiện các thao tác CRUD (Tạo, Đọc, Cập nhật, xóa ) đôi với thông tin sách.
---
## Mục lục
- [Giới thiệu dự án](#giới-thiệu-dự-án)
- [Tính năng](#tính-năng)
- [Công nghệ sử dụng](#công-nghệ-sử-dụng)
- [Cài đặt](#cài-đặt)
- [Sử dụng](#sử-dụng)
---
## Giới thiệu dự án
**BookStoreAPI* được thiết kế để hỗ trợ các nhà quản lý cửa hàng sách trong việc theo dõi và quản lý danh sách sách một cách hiệu quả. API này được tích hợp với cơ sở dữ liệu MongoDB để lưu trữ dữ liệu một cách bền vững.

---
## Tính năng
- Thực hiện các thao tác CRUD (Tạo, Đọc, Cập nhật, Xóa) đối với sách.
- Tích hợp MongoDB để lưu trữ dữ liệu.
- Giao diện Swagger UI để kiểm thử và tài liệu hóa API.
- Kiến trúc đơn giản, dễ dàng mở rộng.

---
## Công nghệ sử dụng
- **Framework**: ASP.NET Core
- **Cơ sở dữ liệu**: MongoDB
- **Công cụ**: Swagger UI
- **Ngôn ngữ**: C#
  
---
## Cài đặt
### Yêu cầu
- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [MongoDB](https://www.mongodb.com/try/download/community)

### Các bước thực hiện
1. Thiết lập cơ sở dữ liệu
![image](https://github.com/user-attachments/assets/71f4d036-12cf-4adf-8939-b12357c672be)

2. Thêm Configuration Model.
-Class **BookStoreDatabaseSettings** : Chứa các thuộc tính cần thiết cho kết nối cơ sở dữ liệu. Được sử dụng để ánh xạ với cấu hình trong appsettings.json.
- Class **Book**: Định nghĩa cấu trúc dữ liệu được lưu trữ trong MongoDB. Mỗi thuộc tính tương ứng với một trường trong collection của MongoDB.

3. Khai báo **BookStoreDatabaseSettings** trong tệp **Program.cs**.

4. Thêm service chứa các thao tác CRUD.
- Tạo class **BookService**:
  + Constructor: Injection đối tượng cấu hình.
  + Các phương thức CRUD:
    - GetAsync(): Lấy danh sách tất cả các sách từ MongoDB.
    - GetAsync(string id): Lấy thông tin chi tiết của một sách dựa vào id.
    - CreateAsync(Book newBook): Thêm mới một sách vào collection Books.
    - UpdateAsync(string id, Book updatedBook): Cập nhật thông tin của sách dựa vào id.
    - RemoveAsync(string id): Xóa một sách dựa vào id.
      
5.  Đăng ký **BooksService** vào Dependency Injection (DI) Container trong **program.cs**.

6.  Thêm **BooksController** và nội dung trong controller là để tạo các API endpoint:
- BooksController thực hiện việc kết nối giữa BooksService và các yêu cầu HTTP.
---
## Sử dụng
### Lấy danh sách tất cả các sách từ MongoDB.
![image](https://github.com/user-attachments/assets/7d3dfd16-edf0-4893-88f8-16d6784a4f5a)

### Lấy thông tin chi tiết của một sách dựa vào id.
![image](https://github.com/user-attachments/assets/b8705be7-07d6-4586-850e-3f2a6dfbb6e5)

### Thêm mới một sách vào Collection Books.
![image](https://github.com/user-attachments/assets/6b1c2b54-86e2-4f99-86c0-b219c7197496)

### Cập nhật thông tin của sách dựa vào id.
![image](https://github.com/user-attachments/assets/8ce33da0-9196-434c-a7ce-74f574ff5d21)

### Xóa một sách dựa vào id.
![image](https://github.com/user-attachments/assets/0964052b-aaad-42a2-a068-3924d925064f)






