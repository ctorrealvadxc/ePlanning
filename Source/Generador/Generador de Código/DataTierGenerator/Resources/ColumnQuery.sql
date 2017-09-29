select INFORMATION_SCHEMA.COLUMNS.*,
	COL_LENGTH('#TableName#', INFORMATION_SCHEMA.COLUMNS.COLUMN_NAME) AS COLUMN_LENGTH,
	COLUMNPROPERTY(OBJECT_ID('#TableName#'), INFORMATION_SCHEMA.COLUMNS.COLUMN_NAME, 'IsComputed') as IS_COMPUTED,
	COLUMNPROPERTY(OBJECT_ID('#TableName#'), INFORMATION_SCHEMA.COLUMNS.COLUMN_NAME, 'IsIdentity') as IS_IDENTITY,
	COLUMNPROPERTY(OBJECT_ID('#TableName#'), INFORMATION_SCHEMA.COLUMNS.COLUMN_NAME, 'IsRowGuidCol') as IS_ROWGUIDCOL,
	COMENTARIO = (SELECT ep.value
				  FROM sys.extended_properties EP
				  INNER JOIN sys.all_objects O ON ep.major_id = O.object_id 
				  INNER JOIN sys.schemas S on O.schema_id = S.schema_id
				  INNER JOIN sys.columns AS c ON ep.major_id = c.object_id AND ep.minor_id = c.column_id
				  WHERE o.object_id = OBJECT_ID('#TableName#') AND C.name = INFORMATION_SCHEMA.COLUMNS.COLUMN_NAME)
from INFORMATION_SCHEMA.COLUMNS
where INFORMATION_SCHEMA.COLUMNS.TABLE_NAME = '#TableName#'
