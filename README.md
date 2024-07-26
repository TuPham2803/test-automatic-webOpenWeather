# test-automatic-webOpenWeather
Trên đây là hai phần chính của dự án:
1. **Unit Testing với NUnit (C#)**.
2. **Unit Testing với Selenium WebDriver**.
# Hệ thống tính Phương trình bậc 2 Và Testing với Selenium WebDriver cùa WebOpenWeather

## Ngôn ngữ
- C#

## Mô tả
Dự án này bao gồm việc phát triển và kiểm thử hệ thống tính nghiệm của phương trình bậc 2 dưới dạng ax^2 + bx + c = 0. Dự án sử dụng NUnit để thực hiện unit tests và Selenium WebDriver cho kiểm thử tự động.

## Chức năng chính

1. **Tính nghiệm của phương trình bậc 2**:
   - **Đầu vào**: Các hệ số a, b, c.
   - **Đầu ra**: Nghiệm của phương trình bậc 2.

### Unit Testing với NUnit (C#)
- **Viết Testcase**: Tạo các testcase để kiểm tra nghiệm của phương trình bậc 2.
- **Thực thi Testcase**: Chạy các testcase tự động bằng cách sử dụng dữ liệu từ file CSV có sẵn.

### Unit Testing với Selenium WebDriver
- **Viết Testcase**: Xây dựng các testcase để kiểm tra các chức năng của ứng dụng web.
  - **Kiểm thử chức năng Login**: 
    - Kiểm tra chức năng đăng nhập bằng cách sử dụng Automation và dữ liệu từ file CSV.
  - **Kiểm thử chức năng tìm kiếm của web OpenWeather**:
    - Kiểm tra chức năng tìm kiếm trên web OpenWeather bằng Automation và đọc dữ liệu từ file CSV.

## Hướng dẫn sử dụng

### 1. Tính nghiệm phương trình bậc 2
- Nhập các hệ số a, b, và c vào hệ thống.
- Chạy chương trình để tính nghiệm của phương trình.

### 2. Unit Testing với NUnit
- **Viết Testcase**: Tạo các testcase để kiểm tra tính chính xác của chức năng tính nghiệm phương trình.
- **Thực thi Testcase**: Sử dụng NUnit để chạy các testcase tự động với dữ liệu từ file CSV.

### 3. Unit Testing với Selenium WebDriver
- **Viết Testcase**: Tạo các testcase cho chức năng Login và chức năng tìm kiếm.
  - **Kiểm thử chức năng Login**:
    - Đăng nhập với thông tin từ file CSV và kiểm tra kết quả.
  - **Kiểm thử chức năng tìm kiếm**:
    - Thực hiện tìm kiếm trên web OpenWeather với dữ liệu từ file CSV và xác minh kết quả.

## Công cụ yêu cầu
- .NET Framework
- NUnit
- Selenium WebDriver
- CSV Reader/Writer

**Chạy Test**: Để thực hiện các test cases, sử dụng NUnit cho unit tests và Selenium WebDriver cho kiểm thử tự động.

---

