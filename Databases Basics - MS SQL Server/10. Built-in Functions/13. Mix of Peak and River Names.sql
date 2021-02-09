SELECT [PeakName], RiverName, LOWER(CONCAT(PeakName, SUBSTRING(RiverName, 2, LEN(RiverName) -1))) AS [Mix] FROM Peaks AS [PeakName], Rivers AS [RiverName]
WHERE RIGHT(PeakName, 1) = LEFT(RiverName, 1)
ORDER BY Mix