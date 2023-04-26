use BagaqueDB

CREATE TABLE Users (
  IdUsers int IDENTITY(1,1) PRIMARY KEY,
  Names varchar(255),
  CPF varchar(50),
  Phone varchar(50),
  PasswordLogin varchar(16),
  EmailLogin varchar(50),
  PostalCode varchar(50),
  NumberAddress varchar(20),
  TypeUser int
  );

CREATE TABLE Orders (
  IdOrders int IDENTITY(1,1) PRIMARY KEY,
  Dater DATETIME,
  FinalDateDelivery DATETIME,
  CodeDelivery int,
  StatusOrder varchar(100),
  TypePayment varchar(50),
  StatusPayment varchar(50),
  IdUser INT,
  FOREIGN KEY (idUser) REFERENCES Users(IdUsers)
);

CREATE TABLE Products (
 IdProducts int IDENTITY(1,1) PRIMARY KEY,
 Title varchar(100),
 Descriptions text,
 Category varchar(50),
 Quantity int,
 Price decimal(10,2),
 Images varchar(150),
 Tags VARCHAR(100),
);

CREATE TABLE ProductOrder (
 IdProductOrder int IDENTITY(1,1) PRIMARY KEY,
 IdProduct int,
 IdOrder int,
 Quantity int,
 FOREIGN KEY (IdProduct) REFERENCES Products(IdProducts),
 FOREIGN KEY (IdOrder) REFERENCES Orders(IdOrders)
);

/*CREATE TABLE Addresses (
  idAddress int IDENTITY(1,1) PRIMARY KEY,
  Addresses varchar(150) not null,
  NumberAddress varchar(20) not null,
  NeighborhoodAddress varchar(100) not null,
  CityAddress varchar(100) not null,
  StateAddress varchar(100) not null,
  CountrydAddress varchar(100) not null,
  PostalCodeAddress varchar(50) not null,
  idUser INT,
  FOREIGN KEY (idUser) REFERENCES Users(idUser)
)*/