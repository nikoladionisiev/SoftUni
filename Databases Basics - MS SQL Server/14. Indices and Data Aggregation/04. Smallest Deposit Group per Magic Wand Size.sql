SELECT TOP(2) DepositGroup FROM
		(
		SELECT DepositGroup, AVG(MagicWandSize) AS [AverageWandSize] 
		FROM WizzardDeposits
		GROUP BY DepositGroup
		)AS [AverageWandSizeQuery] 
							
ORDER BY [AverageWandSize]