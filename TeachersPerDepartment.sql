﻿SELECT COUNT(DISTINCT([ST].[TeacherId])) AS [Number of Teachers], [D].[Title] AS [Department]
FROM [dbo].[Subject] AS [S]
INNER JOIN [dbo].[SubjectTeacher] AS [ST]
ON [S].[SubjectId] = [ST].[SubjectId]
INNER JOIN [dbo].[Department] AS [D]
ON [S].[DepartmentId] = [D].[DepartmentId]
GROUP BY [D].[Title]