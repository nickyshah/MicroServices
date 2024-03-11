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

CREATE TABLE [Rewards] (
    [Id] int NOT NULL IDENTITY,
    [userId] nvarchar(max) NOT NULL,
    [RewardsDate] datetime2 NOT NULL,
    [RewardsActivity] int NOT NULL,
    [OrderId] int NOT NULL,
    CONSTRAINT [PK_Rewards] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240311032725_AddRewardTable', N'8.0.2');
GO

COMMIT;
GO

