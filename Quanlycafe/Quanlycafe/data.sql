CREATE DATABASE QLCafe;
GO

USE QLCafe;
GO

CREATE TABLE Account (
    Name NVARCHAR(50) NULL,
    Username NVARCHAR(50) NULL,
    Password NVARCHAR(50) NULL,
    Role NVARCHAR(10) NULL,
    Phone NVARCHAR(50) NOT NULL
);
GO

CREATE TABLE Invoice (
    ID_Invoice INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Day NVARCHAR(50) NULL,
    [Table] INT NULL,
    Total INT NULL,
    Time NVARCHAR(50) NOT NULL
);
GO

CREATE TABLE Invoice_Detail (
    Name_Product NVARCHAR(50) NULL,
    Quantity INT NULL,
    Price DECIMAL(18, 0) NULL,
    ID_Invoice INT NOT NULL,
    FOREIGN KEY (ID_Invoice) REFERENCES Invoice(ID_Invoice)
);
GO

CREATE TABLE Product_Type (
    ID_Type INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Type NVARCHAR(50) NOT NULL
);
GO

CREATE TABLE Product (
    ID_Product INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Name_Product NVARCHAR(50) NULL,
    Price DECIMAL(18, 0) NULL,
    ID_Type INT NOT NULL,
    Image NVARCHAR(50) NOT NULL,
    FOREIGN KEY (ID_Type) REFERENCES Product_Type(ID_Type)
);
GO

INSERT INTO Account (Name, Username, Password, Role, Phone)
VALUES 
    (N'LDT', 'admin', 'admin', 'manager', '0123456789'),
    (N'NVA', 'user01', 'user01', 'staff', '0123456789');
GO

INSERT INTO Invoice (Day, [Table], Total, Time)
VALUES
    ('27/4/2025', 1, 150000, '21:30:56'),
    ('27/4/2025', 2, 100000, '22:00:00'),
    ('28/4/2025', 3, 15000, '22:00:40');
GO

INSERT INTO Invoice_Detail (Name_Product, Quantity, Price, ID_Invoice)
VALUES
    (N'Capuchino', 5, 20000, 2),
    (N'Trà Gừng', 1, 15000, 3);
GO

INSERT INTO Product_Type (Type)
VALUES
    (N'Đồ nóng'),
    (N'Đồ lạnh'),
    (N'Cafe'),
    (N'Đồ ăn vặt');
GO

INSERT INTO Product (Name_Product, Price, ID_Type, Image)
VALUES
    (N'Cà Phê Sữa', 18000, 3, N'Resource/cafesua.jpeg'),
    (N'Capuchino', 20000, 3, N'Resource/capuchino.jpeg'),
    (N'Matcha', 20000, 2, N'Resource/matcha.jpeg'),
    (N'Trà sữa trân châu', 22000, 2, N'Resource/trasuatranchau.jpeg'),
    (N'Oishi', 6000, 4, N'Resource/oishi.jpeg'),
    (N'Xúc Xích', 10000, 4, N'Resource/xucxich.jpeg'),
    (N'Bắp Nướng', 10000, 4, N'Resource/bapnuong.jpeg'),
    (N'Trà Gừng', 15000, 1, N'Resource/tragung.jpeg'),
    (N'Sữa Nóng', 15000, 1, N'Resource/suanong.jpeg'),
    (N'Khoai Tây Chiên', 12000, 4, N'Resource/khoaitaychien.jpeg'),
    (N'Trà Chanh', 15000, 2, N'Resource/trachanh.jpeg');
GO
