# cSharpCrudSqlServerLocal

Ouvrir le projet Api c#  (*il manque le fichier.sln + d'autres fichiers, ils contiennent des données sensibles*)

Taper dans le terminal nuget : add-migration "initial migration"    
Puis taper : update-database  

si vous avez cette erreur  
![image](https://github.com/user-attachments/assets/5171eecf-3329-4b89-88fc-370c9a3d9840)  
Vous n'avez pas configurer votre server SQL.  
Vous devez ouvrir un terminal en mode Admin.  
![image](https://github.com/user-attachments/assets/cc14da37-05f4-4847-9776-c7e234d78631)  
Taper: *sqllocaldb create "localhost"*  

Un fois le server créer, ouvrir mssms Microsoft SQL Server Management Studio.  
Connectez vous en rentrant le nom du serveur: (localDb)\localhost  
Vous pouver creer la db *EmployeeDb*  

Ensuite, vous pouvez revenir sur le projet C#  
ouvrir le terminal nuget  
Taper: update-database  
![image](https://github.com/user-attachments/assets/2900e1c4-a6f3-4b32-adc2-5338c2563daa)  
C'est OK!  
Vous pouvez verifier sur mssms  

![image](https://github.com/user-attachments/assets/b51929af-1bba-40ad-b0af-af9dc52e02fe)  

Pour tester l'API GET Employees:  
Depuis mssms, vous pouvez editer ou executer un insert d'un employee  
Revenir sur le projet c# et le démarrer.  
swagger UI devrai s'ouvrir.  
Executer l'API GET Employees  
Observez le résultat  
![image](https://github.com/user-attachments/assets/64a118b2-0930-4736-8de5-dc642366f241)  

Pour test l'api post Employees (ajout dans la table employee)  
Démarrer le projet c#  
Executer l'API POST Employees depuis le swagger UI (remplacer les valeurs dans le request body)  
Vous devez avoir ce résultat.  
![image](https://github.com/user-attachments/assets/5d590301-cf55-4894-83ab-b125bc04f7ee)  
Executer l'API GET Employee, vous devez avoir ce résultat:  
![image](https://github.com/user-attachments/assets/aea01528-d3ac-44fd-a8cc-709006e0e8e9)  

Allez sur mssms, fait un select de la table employee.  
Vous devez avoir ce résultat.  
![image](https://github.com/user-attachments/assets/0ff8dcf1-78b1-42f3-8e35-77ee745b99fc)  

Au final vous devez avoir  
![image](https://github.com/user-attachments/assets/f8bad7fa-dc97-419f-8b6a-6e9574f9b8b8)



