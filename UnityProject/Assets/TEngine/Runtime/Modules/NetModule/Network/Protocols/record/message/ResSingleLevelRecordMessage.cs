using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 *  message
 */
public class ResSingleLevelRecordMessage : Message 
{
	//各关卡通关世界纪录
	LevelRecord _levelRecord;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//各关卡通关世界纪录
		SerializeUtils.WriteBean(stream, _levelRecord);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//各关卡通关世界纪录
		_levelRecord = SerializeUtils.ReadBean<LevelRecord>(stream);
	}
	
	/**
	 * 各关卡通关世界纪录
	 */
	public LevelRecord LevelRecord
	{
		set { _levelRecord = value; }
	    get { return _levelRecord; }
	}
	
	
	public override int GetId() 
	{
		return 202102;
	}
}