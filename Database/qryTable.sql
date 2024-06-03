
CREATE TABLE IF NOT EXISTS Member (
    NomorTelepon TEXT PRIMARY KEY,
    Nama TEXT
);


CREATE TABLE IF NOT EXISTS Reservasi (
    NomorTelepon TEXT,
    Nama TEXT,
    TanggalJam DATETIME,
    JumlahOrang INTEGER,
    NomorMeja INTEGER,
    FOREIGN KEY (NomorTelepon) REFERENCES Members(NomorTelepon)
);

CREATE TABLE IF NOT EXISTS Meja (
    NomorMeja INTEGER PRIMARY KEY,
    Status TEXT
);

CREATE TABLE IF NOT EXISTS Menu (
    Nama TEXT PRIMARY KEY,
    Tipe TEXT,
    Harga INTEGER
);


CREATE TABLE IF NOT EXISTS Pesanan (
    IDPesanan INTEGER PRIMARY KEY AUTOINCREMENT,
    ListMenu TEXT,
    TotalMenu INTEGER,
    Status TEXT DEFAULT 'Pending' CHECK (Status IN ('Pending', 'On-Progress', 'Delivered'))
);


DROP TABLE PESANAN
CREATE TABLE IF NOT EXISTS Users (
    ID INTEGER PRIMARY KEY AUTOINCREMENT,
    Nama TEXT,
    NomorTelepon INTEGER
);

DROP TABLE Meja
INSERT INTO Users (Nama, NomorTelepon) VALUES ('Admin', '1234');
INSERT INTO Users (Nama, NomorTelepon) VALUES ('Inez', '4697');
SELECT * FROM Meja
SELECT * FROM Menu
SELECT * FROM Pesanan
SELECT * FROM Reservasi

-- Menambahkan kolom Status ke tabel Pesanan
ALTER TABLE Pesanan
ADD COLUMN Status TEXT;


