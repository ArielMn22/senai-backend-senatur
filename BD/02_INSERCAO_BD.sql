USE SenaTur_Tarde;

INSERT INTO Usuarios(Email, Senha, TipoUsuario)
	VALUES	('admin@admin.com', 'admin', 'ADMINISTRADOR'),
			('cliente@cliente.com', 'cliente', 'CLIENTE')

INSERT INTO Pacotes(NomePacote, Descricao, DataIda, DataVolta, Valor, Ativo, NomeCidade)
	VALUES	('SALVADOR - 5 DIAS / 4 DIÁRIAS', 'O que não falta em Salvador são atrações. Prova disso são as praias, os museus e as construções seculares que dão um charme mais que especial à região. A cidade, sinônimo de alegria, também é conhecida pela efervescência cultural que a credenciou como um dos destinos mais procurados por turistas brasileiros e estrangeiros. O Pelourinho e o Elevador são alguns dos principais pontos de visitação.', '20190806', '20190810', 854.00, 1,'Salvador'),
			('RESORTS NA BAHIA - LITORAL NORTE - 5 DIAS / 4 DIÁRIAS', 'Localizado no estado de Mato Grosso do Sul e ao sul do Pantanal, Bonito possui centenas de cachoeiras, rios e lagos de águas cristalinas, além de cavernas inundadas, paredões rochosos e uma infinidade de peixes. Os aventureiros costumam render-se facilmente a esse destino regado por trilhas ecológicas, passeios de bote e descidas de rapel pelas inúmeras quedas d''água da região.', '20190514', '20190518', 1826.00, 1, 'Salvador'),
			('BONITO VIA CAMPO GRANDE - 1 PASSEIO - 5 DIAS / 4 DIÁRIAS', 'Localizado no estado de Mato Grosso do Sul e ao sul do Pantanal, Bonito possui centenas de cachoeiras, rios e lagos de águas cristalinas, além de cavernas inundadas, paredões rochosos e uma infinidade de peixes. Os aventureiros costumam render-se facilmente a esse destino regado por trilhas ecológicas, passeios de bote e descidas de rapel pelas inúmeras quedas d''água da região.', '20190328', '20190401', 1004.00, 1, 'Bonito')