CREATE TABLE Roles (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(50) NOT NULL,
    Descripción VARCHAR(200),
    Estado TINYINT(1) NOT NULL  -- 1 para activo, 0 para inactivo
);
CREATE TABLE Usuarios (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    NombreUsuario VARCHAR(50) NOT NULL,
    NombreCompleto VARCHAR(100) NOT NULL,
    Edad INT NOT NULL,
    Correo VARCHAR(100) NOT NULL,
    RolID INT NOT NULL,
    FOREIGN KEY (RolID) REFERENCES Roles(ID)
);
