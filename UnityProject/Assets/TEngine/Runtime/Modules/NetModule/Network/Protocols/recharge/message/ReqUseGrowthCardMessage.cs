using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 使用成长卡 message
 */
public class ReqUseGrowthCardMessage : Message 
{
	//商品Id
	int _cardId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//商品Id
		SerializeUtils.WriteInt(stream, _cardId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//商品Id
		_cardId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 商品Id
	 */
	public int CardId
	{
		set { _cardId = value; }
	    get { return _cardId; }
	}
	
	
	public override int GetId() 
	{
		return 312202;
	}
}