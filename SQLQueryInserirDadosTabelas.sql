use BagaqueDB

Select*From Users

INSERT INTO Users (Names,CPF,Phone,PasswordLogin,EmailLogin,PostalCode,NumberAddress,TypeUser)
VALUES 
('Anália', '00000000000', '75988136641', 123456,'analia.nai@gmail.com',40076708,89, 1),
('Jessica','00000000000', '71986336602', 123456,'jessica.luuz@gmail.com',51021000, 209, 1),
('Geismar', '00000000000', '71991680602', 123456,'geismar.samis09@hotmail.com',40076708, 9, 2),
('Edu', '00000000000', '75981095997', 123456,'edducardoso88@gmail.com',44076709, 50, 2),
('Fernando', '00000000000', '75981097210', 123456,'nandotrystan@gmail.com', 44076709, 50,1)

Select*From Orders

INSERT INTO Orders (FinalDateDelivery,CodeDelivery,StatusOrder,TypePayment,StatusPayment,IdUser)
VALUES 
( 2023-05-23, 14,'Aguardando Pagamento','Cartão Credito','Processando Pagamento',1),
( 2023-05-05, 2,'Em separação','Pix','Pagamento Efetuado',3),
( 2023-05-02, 13,'Pedido Encaminhado para trasportadora','Cartão Debito','Pagamento Efetuado',4),
( 2023-04-23, 3,'Entregue','Pix','Pagamento Efetuado',3),
( 2023-04-23, 12,'Aguardando Pagamento','Cartão Credito','Processando Pagamento',2)

Select*From Products

INSERT INTO Products(Title, Descriptions,Category, Quantity,Price ,Images,Tags)
VALUES
('Vingadores Capa Dura - Volume 1',	'Marvel Publicação de 2014','HQ',35, 49.90,'img1','#HQ'),
('Vingadores Capa Dura - Volume 2',	'Marvel Publicação de 2014','HQ',35, 52.90,'img2','#HQ'),
('Vingadores Capa Dura - Volume 3',	'Marvel Publicação de 2014','HQ',35, 46.90,'img3','#HQ'),
('Vingadores Capa Dura - Volume 4',	'Marvel Publicação de 2014','HQ',35, 53.90,'img4','#HQ'),
('Vingadores Capa Dura - Volume 5',	'Marvel Publicação de 2014','HQ',35, 47.90,'img5','#HQ'),
('Guerra Civil  Capa Dura - Volume 1','Marvel Publicação de 2014','HQ',35, 49.90,'img6','#HQ'),
('Guerra Civil  Capa Dura - Volume 2','Marvel Publicação de 2014','HQ',35, 52.90,'img7','#HQ'),
('Guerra Civil  Capa Dura - Volume 3','Marvel Publicação de 2014','HQ',35, 46.90,'img8','#HQ'),
('Guerra Civil  Capa Dura - Volume 4','Marvel Publicação de 2014','HQ',35, 53.90,'img9','#HQ'),
('Guerra Civil  Capa Dura - Volume 5','Marvel Publicação de 2014','HQ',35,	47.90,'img10','#HQ'),
('Invasão Secreta Capa Dura - Volume 1','Marvel Publicação de 2022','HQ',35,49.90,'img11','#HQ'),
('Invasão Secreta Capa Dura - Volume 2','Marvel Publicação de 2022','HQ',35,52.90,'img12','#HQ'),
('Invasão Secreta Capa Dura - Volume 3','Marvel Publicação de 2022','HQ',35,56.90,'img13','#HQ'),
('Invasão Secreta Capa Dura - Volume 4','Marvel Publicação de 2022','HQ',35,53.90,'img14','#HQ'),
('Invasão Secreta Capa Dura - Volume 5','Marvel Publicação de 2022','HQ',35,47.90,'img15','#HQ'),
('Doutor Estranho Capa Dura - Volume 1','Marvel Publicação de 2022','HQ',35,89.90,'img16','#HQ'),
('Doutor Estranho Capa Dura - Volume 2','Marvel Publicação de 2022','HQ',35,72.90,'img17','#HQ'),
('Doutor Estranho Capa Dura - Volume 3','Marvel Publicação de 2022','HQ',35,56.90,'img18','#HQ'),
('Doutor Estranho Capa Dura - Volume 4','Marvel Publicação de 2022','HQ',35,73.90,'img19','#HQ'),
('Doutor Estranho Capa Dura - Volume 5','Marvel Publicação de 2022','HQ',35,87.90,'img20','#HQ'),
('Homem de Ferro Capa Dura - Volume 1','Marvel Essencias Publicação de 2022','HQ',35,69.90,'img21','#HQ'),
('Homem de Ferro Capa Dura - Volume 2','Marvel Essencias Publicação de 2022','HQ',35,62.90,'img22','#HQ'),
('Homem de Ferro Capa Dura - Volume 3','Marvel Essencias Publicação de 2022','HQ',35,46.90,'img23','#HQ'),
('Homem de Ferro Capa Dura - Volume 4','Marvel Essencias Publicação de 2022','HQ',35,53.90,'img24','#HQ'),
('Homem de Ferro Capa Dura - Volume 5','Marvel Essencias Publicação de 2022','HQ',35,47.90,'img25','#HQ'),
('Mulher Maravilha Capa Dura - Volume 1','DC Graphic Novels 2020','HQ',35,59.90,'img26','#HQ'),
('Mulher Maravilha Capa Dura - Volume 2','DC Graphic Novels 2020','HQ',35,52.90,'img27','#HQ'),
('Mulher Maravilha Capa Dura - Volume 3','DC Graphic Novels 2020','HQ',35,46.90,'img28','#HQ'),
('Mulher Maravilha Capa Dura - Volume 4','DC Grapjic Novels 2020','HQ',35,53.90,'img29','#HQ'),
('Mulher Maravilha Capa Dura - Volume 5','DC Graphic Novels 2020','HQ',35,47.90,'img30','#HQ'),
('Liga da Justiça Capa Dura - Volume 1'	,'DC Graphic Novels 2020','HQ',35,69.90,'img31','#HQ'),
('Liga da Justiça Capa Dura - Volume 2'	,'DC Graphics Novels 2020','HQ',35,52.90,'img32','#HQ'),
('Liga da Justiça Capa Dura - Volume 3'	,'DC Graphics Novels 2020','HQ',35,56.90,'img33','#HQ'),
('Liga da Justiça Capa Dura - Volume 4'	,'DC Graphics Novels 2020','HQ',35,53.90,'img34','#HQ'),
('Liga da Justiça Capa Dura – Volume 5'	,'Marvel Publicação de 2022','HQ',35,47.90, 'img35','#HQ'),
('Superman Capa Dura - Volume 1','DC Graphic Novels 2015',	'HQ',35,99.90,'img36','#HQ'),
('Superman Capa Dura - Volume 2','DC Graphic Novels 2015',	'HQ',35,82.90,'img37','#HQ'),
('Superman Capa Dura - Volume 3','DC Graphics Novels 2015',	'HQ',35,76.90,'img38','#HQ'),
('Superman Capa Dura - Volume 4','DCGraphics Novels 2015',	'HQ',35,53.90,'img39','#HQ'),
('Superman Capa Dura - Volume 5','DC Graphics Novels 2015',	'HQ',35,57.90,'img40','#HQ'),
('Batman Capa Dura - Volume 1	','DC Graphics Novels 2016',	'HQ',35,39.90,'img41','#HQ'),
('Batman Capa Dura - Volume 2	','DC  Graphics Novels 2016',	'HQ',35,72.90,'img42','#HQ'),
('Batman Capa Dura - Volume 3	','DC Graphics Novels 2016',	'HQ',35,56.90,'img43','#HQ'),
('Batman Capa Dura - Volume 4	','DC Graphics Novels 2016',	'HQ',35,63.90,'img44','#HQ'),
('Batman Capa Dura - Volume 5	','DC Graphics Novels 2016',	'HQ',35,47.90,'img45','#HQ'),
('Novos Titãs Capa Dura - Volume 1','DC Graphics Novels 2016',	'HQ',35,49.90,'img46','#HQ'),
('Novos Titãs Capa Dura - Volume 2'	,'DC Graphics Novels 2016',	'HQ',35,52.90,'img47','#HQ'),
('Novos Titãs Capa Dura - Volume 3'	,'DC Graphics Novels 2016',	'HQ',35,46.90,'img48','#HQ'),
('Novos Titão Capa Dura - Volume 4'	,'DC Graphics Novels 2016',	'HQ',35,53.90,'img49','#HQ'),
('Novos Titãs Capa Dura - Volume 5'	,'DC Graphics Novels 2016',	'HQ',35,47.90,'img50','#HQ')

Select*From ProductOrder

INSERT INTO ProductOrder (idProduct,idOrder,Quantity)
VALUES
(1,3, 5),
(1,2, 15),
(2,3, 25),
(3,4, 2),
(4,5, 1)

/*Select*From Addresses
INSERT INTO Addresses (Addresses, NumberAddress,NeighborhoodAddress,CityAddress,StateAddress,CountrydAddress,PostalCodeAddress)
VALUES 
('Rua Buenos Aires', 89, 'Parque Getulio Vargas', 'Feira de Santana','Bahia','Brasil',44076708),
('Rua Carlos Gomes', 9, 'Centro', 'Salvador','Bahia','Brasil',40076708),
('Av. Sete de Setembro', 189, 'Centro', 'Salvador','Bahia','Brasil',40076708),
('Av. Boa Viagem',4308, 'Boa Viagem', 'Recife','Pernambuco','Brasil',51021000),
('Rua Bracelona', 89, 'Parque Getulio Vargas', 'Feira de Santana','Bahia','Brasil',44076709)
*/