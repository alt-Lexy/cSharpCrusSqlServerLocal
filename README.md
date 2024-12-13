# cSharpCrudSqlServerLocal

Ouvrir un projet Api c#  

Taper dans le terminal nuget : add-migration "initial migration"    
Puis taper : update-database  

si vous avez cette erreur  
![image](https://github.com/user-attachments/assets/5171eecf-3329-4b89-88fc-370c9a3d9840)  
Vous n'avez pas configurer votre server SQL.  
Vous devez ouvrir un terminal en mode Admin.  
![image](https://github.com/user-attachments/assets/cc14da37-05f4-4847-9776-c7e234d78631)  
Taper: *sqllocaldb create "localhost"*  

Un fois le server créer, ouvrir mssms Microsoft SQL Server Management Studio.
Connecte vous en rentrant le nom du serveur: (localDb)\localhost  
Vous pouver creer la db *EmployeeDb*  

Ensuite, vous pouvez revenir sur le projet C#  
ouvrir le terminal nuget  
Taper: update-database  
![image](https://github.com/user-attachments/assets/2900e1c4-a6f3-4b32-adc2-5338c2563daa)  
C'est OK!  
Vous pouvez verifier sur mssms



