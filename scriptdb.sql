USE [master]
GO
/****** Object:  Database [proyecto_taller2]    Script Date: 19/10/2023 05:27:06 ******/
CREATE DATABASE [proyecto_taller2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'proyecto_taller2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\proyecto_taller2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'proyecto_taller2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\proyecto_taller2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [proyecto_taller2] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [proyecto_taller2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [proyecto_taller2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [proyecto_taller2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [proyecto_taller2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [proyecto_taller2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [proyecto_taller2] SET ARITHABORT OFF 
GO
ALTER DATABASE [proyecto_taller2] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [proyecto_taller2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [proyecto_taller2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [proyecto_taller2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [proyecto_taller2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [proyecto_taller2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [proyecto_taller2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [proyecto_taller2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [proyecto_taller2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [proyecto_taller2] SET  ENABLE_BROKER 
GO
ALTER DATABASE [proyecto_taller2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [proyecto_taller2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [proyecto_taller2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [proyecto_taller2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [proyecto_taller2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [proyecto_taller2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [proyecto_taller2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [proyecto_taller2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [proyecto_taller2] SET  MULTI_USER 
GO
ALTER DATABASE [proyecto_taller2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [proyecto_taller2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [proyecto_taller2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [proyecto_taller2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [proyecto_taller2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [proyecto_taller2] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [proyecto_taller2] SET QUERY_STORE = ON
GO
ALTER DATABASE [proyecto_taller2] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [proyecto_taller2]
GO
/****** Object:  Table [dbo].[categoria]    Script Date: 19/10/2023 05:27:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categoria](
	[id_categoria] [int] IDENTITY(1,1) NOT NULL,
	[descripcion_categoria] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 19/10/2023 05:27:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientes](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre_cliente] [varchar](20) NULL,
	[apellido_cliente] [varchar](20) NULL,
	[DNI_cliente] [int] NOT NULL,
	[telefono_cliente] [varchar](30) NOT NULL,
	[direccion_cliente] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[factura]    Script Date: 19/10/2023 05:27:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[factura](
	[id_factura] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[tipo_pago] [varchar](15) NOT NULL,
	[id_cliente] [int] NOT NULL,
	[id_usuario] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[factura_detalle]    Script Date: 19/10/2023 05:27:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[factura_detalle](
	[id_venta_detalle] [int] IDENTITY(1,1) NOT NULL,
	[id_producto] [int] NOT NULL,
	[id_factura] [int] NOT NULL,
	[importe_total] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_venta_detalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[marca]    Script Date: 19/10/2023 05:27:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[marca](
	[id_marca] [int] IDENTITY(1,1) NOT NULL,
	[descripcion_marca] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_marca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pago]    Script Date: 19/10/2023 05:27:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[productos](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[nombre_producto] [varchar](20) NOT NULL,
	[id_marca] [int] NOT NULL,
	[stock] [int] NOT NULL,
	[precio] [float] NOT NULL,
	[descripcion] [varchar](20) NOT NULL,
	[id_categoria] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipo_usuario]    Script Date: 19/10/2023 05:27:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_usuario](
	[id_tipo_usuario] [int] IDENTITY(1,1) NOT NULL,
	[descripcion_tipo_usuario] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tipo_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 19/10/2023 05:27:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[nombre_usuario] [varchar](20) NOT NULL,
	[apellido_usuario] [varchar](20) NOT NULL,
	[telefono_usuario] [varchar](20) NOT NULL,
	[usuario] [varchar](20) NOT NULL,
	[contraseña] [varchar](20) NOT NULL,
	[id_tipo_usuario] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tipo_usuario] ([id_tipo_usuario], [descripcion_tipo_usuario]) VALUES (1, N'superadmin')
INSERT [dbo].[tipo_usuario] ([id_tipo_usuario], [descripcion_tipo_usuario]) VALUES (2, N'admin')
INSERT [dbo].[tipo_usuario] ([id_tipo_usuario], [descripcion_tipo_usuario]) VALUES (3, N'vendedor')
GO
SET IDENTITY_INSERT [dbo].[usuario] ON 

INSERT [dbo].[usuario] ([id_usuario], [nombre_usuario], [apellido_usuario], [telefono_usuario], [usuario], [contraseña], [id_tipo_usuario]) VALUES (6, N'Tomas', N'Collar', N'3794868139', N'tomascollar', N'1234', 1)
INSERT [dbo].[usuario] ([id_usuario], [nombre_usuario], [apellido_usuario], [telefono_usuario], [usuario], [contraseña], [id_tipo_usuario]) VALUES (7, N'Admin', N'Admin', N'111111', N'admin', N'1234', 2)
INSERT [dbo].[usuario] ([id_usuario], [nombre_usuario], [apellido_usuario], [telefono_usuario], [usuario], [contraseña], [id_tipo_usuario]) VALUES (8, N'Toni', N'Collar', N'1111', N'toni_vendedor', N'12345', 3)
INSERT [dbo].[usuario] ([id_usuario], [nombre_usuario], [apellido_usuario], [telefono_usuario], [usuario], [contraseña], [id_tipo_usuario]) VALUES (9, N'asda', N'asd', N'123', N'vendedor', N'1234', 3)
SET IDENTITY_INSERT [dbo].[usuario] OFF
GO
ALTER TABLE [dbo].[factura]  WITH CHECK ADD  CONSTRAINT [FK_id_cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[clientes] ([id_cliente])
GO
ALTER TABLE [dbo].[factura] CHECK CONSTRAINT [FK_id_cliente]
GO
ALTER TABLE [dbo].[factura]  WITH CHECK ADD  CONSTRAINT [FK_id_pago] FOREIGN KEY([id_pago])
REFERENCES [dbo].[pago] ([id_pago])
GO
ALTER TABLE [dbo].[factura] CHECK CONSTRAINT [FK_id_pago]
GO
ALTER TABLE [dbo].[factura]  WITH CHECK ADD  CONSTRAINT [FK_id_usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[factura] CHECK CONSTRAINT [FK_id_usuario]
GO
ALTER TABLE [dbo].[factura_detalle]  WITH CHECK ADD  CONSTRAINT [FK_id_producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[productos] ([id_producto])
GO
ALTER TABLE [dbo].[factura_detalle] CHECK CONSTRAINT [FK_id_producto]
GO
ALTER TABLE [dbo].[factura_detalle]  WITH CHECK ADD  CONSTRAINT [FK_id_venta] FOREIGN KEY([id_factura])
REFERENCES [dbo].[factura] ([id_factura])
GO
ALTER TABLE [dbo].[factura_detalle] CHECK CONSTRAINT [FK_id_venta]
GO
ALTER TABLE [dbo].[productos]  WITH CHECK ADD  CONSTRAINT [FK_id_categoria] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[categoria] ([id_categoria])
GO
ALTER TABLE [dbo].[productos] CHECK CONSTRAINT [FK_id_categoria]
GO
ALTER TABLE [dbo].[productos]  WITH CHECK ADD  CONSTRAINT [FK_id_marca] FOREIGN KEY([id_marca])
REFERENCES [dbo].[marca] ([id_marca])
GO
ALTER TABLE [dbo].[productos] CHECK CONSTRAINT [FK_id_marca]
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [FK_id_tipo_usuario] FOREIGN KEY([id_tipo_usuario])
REFERENCES [dbo].[tipo_usuario] ([id_tipo_usuario])
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [FK_id_tipo_usuario]
GO
ALTER TABLE [dbo].[clientes]  WITH CHECK ADD CHECK  ((len([DNI_cliente])>=(6) AND len([DNI_cliente])<=(8)))
GO
ALTER TABLE [dbo].[pago]  WITH CHECK ADD CHECK  (([tipo_pago]='debito' OR [tipo_pago]='efectivo'))
GO
ALTER TABLE [dbo].[tipo_usuario]  WITH CHECK ADD CHECK  (([descripcion_tipo_usuario]='vendedor' OR [descripcion_tipo_usuario]='superadmin' OR [descripcion_tipo_usuario]='admin'))
GO
USE [master]
GO
ALTER DATABASE [proyecto_taller2] SET  READ_WRITE 
GO
