IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [FormaEntregas] (
    [FormaEntregaId] int NOT NULL IDENTITY,
    [Descripcion] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_FormaEntregas] PRIMARY KEY ([FormaEntregaId])
);
GO

CREATE TABLE [Mercaderias] (
    [MercaderiaId] int NOT NULL IDENTITY,
    [Nombre] nvarchar(max) NOT NULL,
    [TipoMercaderiaId] int NOT NULL,
    [Precio] int NOT NULL,
    [Ingredientes] nvarchar(max) NOT NULL,
    [Preparacion] nvarchar(max) NOT NULL,
    [Imagen] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Mercaderias] PRIMARY KEY ([MercaderiaId])
);
GO

CREATE TABLE [TipoMercaderias] (
    [TipoMercaderiaId] int NOT NULL IDENTITY,
    [Descripcion] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_TipoMercaderias] PRIMARY KEY ([TipoMercaderiaId])
);
GO

CREATE TABLE [Comandas] (
    [ComandaId] uniqueidentifier NOT NULL,
    [FormaEntregaId] int NOT NULL,
    [PrecioTotal] int NOT NULL,
    [Date] datetime2 NOT NULL,
    CONSTRAINT [PK_Comandas] PRIMARY KEY ([ComandaId]),
    CONSTRAINT [FK_Comandas_FormaEntregas_FormaEntregaId] FOREIGN KEY ([FormaEntregaId]) REFERENCES [FormaEntregas] ([FormaEntregaId]) ON DELETE CASCADE
);
GO

CREATE TABLE [comandaMercaderias] (
    [ComandaMercaderiaId] int NOT NULL IDENTITY,
    [ComandaId] uniqueidentifier NOT NULL,
    [MercaderiaId] int NOT NULL,
    CONSTRAINT [PK_comandaMercaderias] PRIMARY KEY ([ComandaMercaderiaId]),
    CONSTRAINT [FK_comandaMercaderias_Comandas_ComandaId] FOREIGN KEY ([ComandaId]) REFERENCES [Comandas] ([ComandaId]) ON DELETE CASCADE,
    CONSTRAINT [FK_comandaMercaderias_Mercaderias_MercaderiaId] FOREIGN KEY ([MercaderiaId]) REFERENCES [Mercaderias] ([MercaderiaId]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_comandaMercaderias_ComandaId] ON [comandaMercaderias] ([ComandaId]);
GO

CREATE INDEX [IX_comandaMercaderias_MercaderiaId] ON [comandaMercaderias] ([MercaderiaId]);
GO

CREATE INDEX [IX_Comandas_FormaEntregaId] ON [Comandas] ([FormaEntregaId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230403002234_init', N'7.0.4');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DROP INDEX [IX_Comandas_FormaEntregaId] ON [Comandas];
GO

CREATE INDEX [IX_Mercaderias_TipoMercaderiaId] ON [Mercaderias] ([TipoMercaderiaId]);
GO

CREATE UNIQUE INDEX [IX_Comandas_FormaEntregaId] ON [Comandas] ([FormaEntregaId]);
GO

ALTER TABLE [Mercaderias] ADD CONSTRAINT [FK_Mercaderias_TipoMercaderias_TipoMercaderiaId] FOREIGN KEY ([TipoMercaderiaId]) REFERENCES [TipoMercaderias] ([TipoMercaderiaId]) ON DELETE CASCADE;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230403022453_relationship-complete', N'7.0.4');
GO

COMMIT;
GO

