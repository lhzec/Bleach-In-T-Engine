using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 月卡持续时间 message
 */
public class ResMonthCardTimeMessage : Message 
{
	//月卡Id
	int _cardId;	
	//月卡持续时间（秒）
	int _lastTime;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//月卡Id
		SerializeUtils.WriteInt(stream, _cardId);
		//月卡持续时间（秒）
		SerializeUtils.WriteInt(stream, _lastTime);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//月卡Id
		_cardId = SerializeUtils.ReadInt(stream);
		//月卡持续时间（秒）
		_lastTime = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 月卡Id
	 */
	public int CardId
	{
		set { _cardId = value; }
	    get { return _cardId; }
	}
	
	/**
	 * 月卡持续时间（秒）
	 */
	public int LastTime
	{
		set { _lastTime = value; }
	    get { return _lastTime; }
	}
	
	
	public override int GetId() 
	{
		return 312103;
	}
}