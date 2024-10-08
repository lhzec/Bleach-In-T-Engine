using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 创建玩家 message
 */
public class ReqCreatePlayerMessage : Message 
{
	//角色名字
	string _name;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//角色名字
		SerializeUtils.WriteString(stream, _name);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//角色名字
		_name = SerializeUtils.ReadString(stream);
	}
	
	/**
	 * 角色名字
	 */
	public string Name
	{
		set { _name = value; }
	    get { return _name; }
	}
	
	
	public override int GetId() 
	{
		return 100202;
	}
}