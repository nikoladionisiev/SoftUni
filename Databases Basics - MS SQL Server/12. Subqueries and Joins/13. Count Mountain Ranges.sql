SELECT CountryCode, COUNT(MountainID) AS [MountainRanges] FROM MountainsCountries 
WHERE CountryCode IN ('US', 'BG', 'RU')
GROUP BY CountryCode