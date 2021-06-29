﻿CREATE TABLE [dbo].[MarcaVehiculo]
(
	  MarcaVehiculoId INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_MarcaVehiculo  PRIMARY KEY CLUSTERED(MarcaVehiculoId)
	, Descripcion VARCHAR(250)
	, Estado BIT NOT NULL
) WITH (DATA_COMPRESSION=PAGE)
