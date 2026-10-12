-- 1) Historial de migraciones aplicadas
SELECT MigrationId, ProductVersion FROM __EFMigrationsHistory;
 
-- 2) Llaves foráneas y su comportamiento al eliminar
SELECT f.name                           AS LlaveForanea,
       OBJECT_NAME(f.parent_object_id)  AS Tabla,
       f.delete_referential_action_desc AS AlEliminar
FROM sys.foreign_keys f
ORDER BY Tabla;

Select * from Categorias;
Select * from Usuarios;
Select * from Productos;