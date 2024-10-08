using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 使用成长卡回复 message
 */
public class ResUseGrowthCardMessage : Message 
{
	//成长卡Id
	int _cardId;	
	//使用到的位置
	int _usedValue;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//成长卡Id
		SerializeUtils.WriteInt(stream, _cardId);
		//使用到的位置
		SerializeUtils.WriteInt(stream, _usedValue);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//成长卡Id
		_cardId = SerializeUtils.ReadInt(stream);
		//使用到的位置
		_usedValue = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 成长卡Id
	 */
	public int CardId
	{
		set { _cardId = value; }
	    get { return _cardId; }
	}
	
	/**
	 * 使用到的位置
	 */
	public int UsedValue
	{
		set { _usedValue = value; }
	    get { return _usedValue; }
	}
	
	
	public override int GetId() 
	{
		return 312104;
	}
}