USE [master]
GO
/****** Object:  Database [Gestion_Stock]    Script Date: 11/30/2022 2:11:14 AM ******/
CREATE DATABASE [Gestion_Stock]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Gestion_Stock', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Gestion_Stock.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Gestion_Stock_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Gestion_Stock_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Gestion_Stock] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Gestion_Stock].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Gestion_Stock] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Gestion_Stock] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Gestion_Stock] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Gestion_Stock] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Gestion_Stock] SET ARITHABORT OFF 
GO
ALTER DATABASE [Gestion_Stock] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Gestion_Stock] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Gestion_Stock] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Gestion_Stock] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Gestion_Stock] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Gestion_Stock] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Gestion_Stock] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Gestion_Stock] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Gestion_Stock] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Gestion_Stock] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Gestion_Stock] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Gestion_Stock] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Gestion_Stock] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Gestion_Stock] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Gestion_Stock] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Gestion_Stock] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Gestion_Stock] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Gestion_Stock] SET RECOVERY FULL 
GO
ALTER DATABASE [Gestion_Stock] SET  MULTI_USER 
GO
ALTER DATABASE [Gestion_Stock] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Gestion_Stock] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Gestion_Stock] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Gestion_Stock] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Gestion_Stock] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Gestion_Stock] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Gestion_Stock', N'ON'
GO
ALTER DATABASE [Gestion_Stock] SET QUERY_STORE = OFF
GO
USE [Gestion_Stock]
GO
/****** Object:  Table [dbo].[achat]    Script Date: 11/30/2022 2:11:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[achat](
	[id_achat] [int] NOT NULL,
	[date_achat] [date] NOT NULL,
	[qte_achat] [int] NOT NULL,
	[id_prod] [int] NOT NULL,
	[id_fourn] [int] NOT NULL,
	[id_user] [int] NOT NULL,
	[note_achat] [ntext] NULL,
 CONSTRAINT [PK_achat] PRIMARY KEY CLUSTERED 
(
	[id_achat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[client]    Script Date: 11/30/2022 2:11:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[client](
	[id_client] [int] NOT NULL,
	[nom_client] [nvarchar](50) NOT NULL,
	[adresse_client] [ntext] NOT NULL,
	[tele_client] [nchar](10) NOT NULL,
	[note_client] [ntext] NULL,
	[email_client] [ntext] NULL,
 CONSTRAINT [PK_client] PRIMARY KEY CLUSTERED 
(
	[id_client] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[fournisseurs]    Script Date: 11/30/2022 2:11:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fournisseurs](
	[id_fourn] [int] NOT NULL,
	[nom_fourn] [nchar](20) NOT NULL,
	[adresse_fourn] [ntext] NOT NULL,
	[tele_fourn] [nchar](10) NOT NULL,
	[note_fourn] [ntext] NULL,
	[email_fourn] [ntext] NULL,
 CONSTRAINT [PK_fournisseurs] PRIMARY KEY CLUSTERED 
(
	[id_fourn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[produits]    Script Date: 11/30/2022 2:11:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[produits](
	[id_prod] [int] NOT NULL,
	[libelle_prod] [nvarchar](50) NOT NULL,
	[pu_prod] [decimal](18, 3) NOT NULL,
	[type_prod] [nchar](10) NOT NULL,
	[prix_vente] [decimal](18, 3) NOT NULL,
	[note_prod] [ntext] NULL,
	[code_barre] [int] NULL,
 CONSTRAINT [PK_produits] PRIMARY KEY CLUSTERED 
(
	[id_prod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 11/30/2022 2:11:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id_user] [int] NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password_user] [nchar](10) NOT NULL,
	[nom_user] [nchar](10) NOT NULL,
	[prenom_user] [nchar](10) NOT NULL,
	[tele_user] [nchar](10) NOT NULL,
	[type_user] [nchar](10) NOT NULL,
	[note_user] [ntext] NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vente]    Script Date: 11/30/2022 2:11:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vente](
	[id_vente] [int] NOT NULL,
	[date_vente] [date] NOT NULL,
	[qte_vente] [int] NOT NULL,
	[pu_achat] [decimal](15, 3) NOT NULL,
	[pu_vente] [decimal](15, 3) NOT NULL,
	[payer_nonpayer] [ntext] NOT NULL,
	[profit] [decimal](15, 3) NOT NULL,
	[id_prod] [int] NOT NULL,
	[id_client] [int] NOT NULL,
	[id_user] [int] NOT NULL,
	[note_vente] [ntext] NULL,
	[methode_paiement] [varchar](20) NOT NULL,
 CONSTRAINT [PK_vente] PRIMARY KEY CLUSTERED 
(
	[id_vente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[achat]  WITH CHECK ADD  CONSTRAINT [FK_achat_fournisseurs] FOREIGN KEY([id_fourn])
REFERENCES [dbo].[fournisseurs] ([id_fourn])
GO
ALTER TABLE [dbo].[achat] CHECK CONSTRAINT [FK_achat_fournisseurs]
GO
ALTER TABLE [dbo].[achat]  WITH CHECK ADD  CONSTRAINT [FK_achat_produits] FOREIGN KEY([id_prod])
REFERENCES [dbo].[produits] ([id_prod])
GO
ALTER TABLE [dbo].[achat] CHECK CONSTRAINT [FK_achat_produits]
GO
ALTER TABLE [dbo].[achat]  WITH CHECK ADD  CONSTRAINT [FK_achat_users] FOREIGN KEY([id_user])
REFERENCES [dbo].[users] ([id_user])
GO
ALTER TABLE [dbo].[achat] CHECK CONSTRAINT [FK_achat_users]
GO
ALTER TABLE [dbo].[vente]  WITH CHECK ADD  CONSTRAINT [FK_vente_client] FOREIGN KEY([id_client])
REFERENCES [dbo].[client] ([id_client])
GO
ALTER TABLE [dbo].[vente] CHECK CONSTRAINT [FK_vente_client]
GO
ALTER TABLE [dbo].[vente]  WITH CHECK ADD  CONSTRAINT [FK_vente_produits] FOREIGN KEY([id_prod])
REFERENCES [dbo].[produits] ([id_prod])
GO
ALTER TABLE [dbo].[vente] CHECK CONSTRAINT [FK_vente_produits]
GO
ALTER TABLE [dbo].[vente]  WITH CHECK ADD  CONSTRAINT [FK_vente_users] FOREIGN KEY([id_user])
REFERENCES [dbo].[users] ([id_user])
GO
ALTER TABLE [dbo].[vente] CHECK CONSTRAINT [FK_vente_users]
GO
USE [master]
GO
ALTER DATABASE [Gestion_Stock] SET  READ_WRITE 
GO
