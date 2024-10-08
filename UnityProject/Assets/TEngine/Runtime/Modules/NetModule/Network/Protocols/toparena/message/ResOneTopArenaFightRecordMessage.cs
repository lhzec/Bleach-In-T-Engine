using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 单条对战记录 message
 */
public class ResOneTopArenaFightRecordMessage : Message 
{
	//对战记录列表
	TopArenaFightRecord _fightRecord;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//对战记录列表
		SerializeUtils.WriteBean(stream, _fightRecord);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//对战记录列表
		_fightRecord = SerializeUtils.ReadBean<TopArenaFightRecord>(stream);
	}
	
	/**
	 * 对战记录列表
	 */
	public TopArenaFightRecord FightRecord
	{
		set { _fightRecord = value; }
	    get { return _fightRecord; }
	}
	
	
	public override int GetId() 
	{
		return 503107;
	}
}