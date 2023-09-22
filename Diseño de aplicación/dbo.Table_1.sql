CREATE TABLE [dbo].[Clientes] (
    [cliDocumento] INT            NOT NULL,
    [cliNombre]    VARCHAR (MAX)  NOT NULL,
    [cliDireccion] NVARCHAR (MAX) NOT NULL,
    [cliTelefono]  NVARCHAR (MAX) NOT NULL,
    [cliCorreo]    NVARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([cliDocumento] ASC)
);

