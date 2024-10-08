using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求做普通料理消息 message
 */
public class ReqCookFoodMessage : Message 
{
	//料理编号
	int _foodId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//料理编号
		SerializeUtils.WriteInt(stream, _foodId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//料理编号
		_foodId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 料理编号
	 */
	public int FoodId
	{
		set { _foodId = value; }
	    get { return _foodId; }
	}
	
	
	public override int GetId() 
	{
		return 106202;
	}
}