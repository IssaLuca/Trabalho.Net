﻿IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Jogador] (
    [JogadorID] int NOT NULL IDENTITY,
    [Idade] int NOT NULL,
    [Nome] nvarchar(max) NULL,
    [Nacionalidade] nvarchar(max) NULL,
    CONSTRAINT [PK_Jogador] PRIMARY KEY ([JogadorID])
);

GO

CREATE TABLE [Placar] (
    [PlacarID] int NOT NULL IDENTITY,
    [JogadorID] int NOT NULL,
    [Data] datetime2 NOT NULL,
    [Pontuacao] int NOT NULL,
    CONSTRAINT [PK_Placar] PRIMARY KEY ([PlacarID]),
    CONSTRAINT [FK_Placar_Jogador_JogadorID] FOREIGN KEY ([JogadorID]) REFERENCES [Jogador] ([JogadorID]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_Placar_JogadorID] ON [Placar] ([JogadorID]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20191213193252_InitialCreate', N'2.1.11-servicing-32099');

GO

