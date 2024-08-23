INSERT INTO Roles (Nombre, Descripción, Estado)
VALUES ('Administrador', 'Administrador del sistema', 1),
       ('Usuario', 'Usuario regular con acceso básico', 1),
       ('Moderador', 'Usuario con permisos de moderación', 1);

INSERT INTO Usuarios (NombreUsuario, NombreCompleto, Edad, Correo, RolID)
VALUES ('admin', 'Administrador del Sistema', 35, 'admin@tuapp.com', 1),
       ('jdoe', 'John Doe', 28, 'jdoe@tuapp.com', 2),
       ('mmoderator', 'Maria Moderator', 30, 'maria@tuapp.com', 3);