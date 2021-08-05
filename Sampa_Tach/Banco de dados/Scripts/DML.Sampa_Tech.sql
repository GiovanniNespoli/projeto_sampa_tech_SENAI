USE Sampa_tech;

INSERT INTO Usuario(NomeUsuario,Email,Senha,TipoUsuario)
VALUES				('Administrador','adm@adm.com','adm123',0),
					('Cliente','Cliente@cliente.com','cliente132',1),
					('Cristian','Cristian@gmail.com','Cris132',1)

INSERT INTO Sala(Andar,Nome,Metragemsala)
VALUES			('1','1-A','30mx25m'),
				('2','2-A','35mx25m')

INSERT INTO Equipamento(Marca,TipoEquipamento,NumeroSerie,Descricao,AtivoInativo,NumeroPatrimonio)
VALUES					('LG','EletroEletronico','3080021101','Televisor Smart Led 42 polegadas','1','10001'),
						('LG','EletroEletronico','3080021102','Televisor Smart Led 42 polegadas','1','10002'),
						('Samsung','Informatica','3080021201','Notebook i7-7K','1','10004'),
						('Samsung','Informatica','3080021202','Notebook i7-7K','1','10005'),
						('MadeiraMadeira','Mobiliario','3080021301','Mesa para estudante','1','10007'), 
						('MadeiraMadeira','Mobiliario','3080021302','Mesa para estudante','1','10008'),
						('MadeiraMadeira','Mobiliario','3080021304','Mesa para estudante','1','10010'),
						('RikStok','Mobiliario','3080021401','Mesa para professor','1','10013'),
						('RikStok','Mobiliario','3080021402','Mesa para professor','1','10014'),
						('Mobly','Mobiliario','3080021501','Cadeira ajustavel','1','10016'),
						('Mobly','Mobiliario','3080021502','Cadeira ajustavel','1','10017'),
						('Mobly','Mobiliario','3080021503','Cadeira ajustavel','1','10018'),
						('Mobly','Mobiliario','3080021504','Cadeira ajustavel','1','10019'),
						('Mobly','Mobiliario','3080021505','Cadeira ajustavel','1','10020'),
						('Mobly','Mobiliario','3080021506','Cadeira ajustavel','1','10021')

INSERT INTO SalaEquip(idSala,idEquipamento,DataEntrada,DataSaida)
VALUES				(1,1,'30/07/2021',''),
					(1,3,'30/07/2021',''),
					(1,5,'30/07/2021',''),
					(1,6,'30/07/2021',''),
					(1,9,'30/07/2021',''),
					(1,11,'30/07/2021',''),
					(1,12,'30/07/2021',''),
					(1,13,'30/07/2021',''),
					(2,2,'30/07/2021',''),
					(2,4,'30/07/2021',''),
					(2,7,'30/07/2021',''),
					(2,8,'30/07/2021',''),
					(2,10,'30/07/2021',''),
					(2,14,'30/07/2021',''),
					(2,15,'30/07/2021','')
					
