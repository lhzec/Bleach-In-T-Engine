using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求保存玩家使用外挂的信息 message
 */
public class ReqPlayerHackTypeMessage : Message 
{
	//0-变速齿轮 1-内存修改
	int _type;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0-变速齿轮 1-内存修改
		SerializeUtils.WriteInt(stream, _type);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0-变速齿轮 1-内存修改
		_type = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0-变速齿轮 1-内存修改
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	
	public override int GetId() 
	{
		return 105204;
	}
}