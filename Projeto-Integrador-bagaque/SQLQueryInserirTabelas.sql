use BagaqueDB

CREATE TABLE Users (
  IdUser int IDENTITY(1,1) PRIMARY KEY,
  NameUser varchar(255) not null,
  CPFUser varchar(50) not null,
  PhoneUser varchar(50) not null,
  SenhaLoginUser varchar(16) not null,
  EmailLoginUser varchar(50) not null,
  PostalCodeUser varchar(50) not null,
  NumberUser varchar(20) not null,
  TypeUser int not null
  );

CREATE TABLE Orders (
  IdOrder int IDENTITY(1,1) PRIMARY KEY,
  DateOrder DATETIME not null,
  FinalDateDeliveryOrder DATETIME not null,
  CodeDeliveryOrder int not null,
  StatusOrder varchar(100) not null,
  TypePaymentOrder varchar(50) not null,
  StatusPaymentOrder varchar(50) not null,
  idUser INT,
  FOREIGN KEY (idUser) REFERENCES Users(idUser)
);

CREATE TABLE Product (
 idProduct int IDENTITY(1,1) PRIMARY KEY NOT NULL,
 TitleProduct varchar(100) NOT NULL,
 DescriptionProduct text NOT NULL,
 CategoryProduct varchar(50) NOT NULL,
 QuantityProduct int NOT NULL,
 PriceProduct decimal(10,2) NOT NULL,
 ImageProduct varchar(150) not NULL,
TagsProduct VARCHAR(100) not NULL ,
);

CREATE TABLE ProductOrder (
 IdProduct int NOT NULL,
 IdOrder int Not null,
 QuantityProductOrder int not null,
 FOREIGN KEY (IdProduct) REFERENCES Product(idProduct),
 FOREIGN KEY (IdOrder) REFERENCES Orders(IdOrder)
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