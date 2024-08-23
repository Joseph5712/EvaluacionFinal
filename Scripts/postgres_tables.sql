CREATE TABLE Roles (
    ID SERIAL PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL,
    Descripción VARCHAR(200),
    Estado BOOLEAN NOT NULL  -- TRUE para activo, FALSE para inactivo
);

CREATE TABLE Usuarios (
    ID SERIAL PRIMARY KEY,
    NombreUsuario VARCHAR(50) NOT NULL,
    NombreCompleto VARCHAR(100) NOT NULL,
    Edad INT NOT NULL,
    Correo VARCHAR(100) NOT NULL,
    RolID INT NOT NULL,
    CONSTRAINT FK_Usuarios_Roles FOREIGN KEY (RolID) REFERENCES Roles(ID)
);
