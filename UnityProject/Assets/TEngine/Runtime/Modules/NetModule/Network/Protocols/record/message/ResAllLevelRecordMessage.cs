using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 *  message
 */
public class ResAllLevelRecordMessage : Message 
{
	//各关卡通关世界纪录
	List<LevelRecord> _levelRecord = new List<LevelRecord>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//各关卡通关世界纪录
		SerializeUtils.WriteShort(stream, (short)_levelRecord.Count);

		foreach (var element in _levelRecord)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//各关卡通关世界纪录
		int _levelRecord_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _levelRecord_length; ++i) 
		{
			_levelRecord.Add(SerializeUtils.ReadBean<LevelRecord>(stream));
		}
	}
	
	/**
	 * get 各关卡通关世界纪录
	 * @return 
	 */
	public List<LevelRecord> GetLevelRecord()
	{
		return _levelRecord;
	}
	
	/**
	 * set 各关卡通关世界纪录
	 */
	public void SetLevelRecord(List<LevelRecord> levelRecord)
	{
		_levelRecord = levelRecord;
	}
	
	
	public override int GetId() 
	{
		return 202101;
	}
}