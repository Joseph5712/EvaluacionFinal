INSERT INTO Roles (Nombre, Descripción, Estado)
VALUES ('Administrador', 'Administrador del sistema', TRUE),
       ('Usuario', 'Usuario regular con acceso básico', TRUE),
       ('Moderador', 'Usuario con permisos de moderación', TRUE);

INSERT INTO Usuarios (NombreUsuario, NombreCompleto, Edad, Correo, RolID)
VALUES ('admin', 'Administrador del Sistema', 35, 'admin@tuapp.com', 1),
       ('jdoe', 'John Doe', 28, 'jdoe@tuapp.com', 2),
       ('mmoderator', 'Maria Moderator', 30, 'maria@tuapp.com', 3);
