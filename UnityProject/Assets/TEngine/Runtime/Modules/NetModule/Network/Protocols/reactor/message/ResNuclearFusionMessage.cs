using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 发送合成信息 message
 */
public class ResNuclearFusionMessage : Message 
{
	//成功0 1 失败
	byte _returnInfo;	
	//合成0 1分解
	byte _type;	
	//返回信息
	ItemInfo _itemInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//成功0 1 失败
		SerializeUtils.WriteByte(stream, _returnInfo);
		//合成0 1分解
		SerializeUtils.WriteByte(stream, _type);
		//返回信息
		SerializeUtils.WriteBean(stream, _itemInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//成功0 1 失败
		_returnInfo = SerializeUtils.ReadByte(stream);
		//合成0 1分解
		_type = SerializeUtils.ReadByte(stream);
		//返回信息
		_itemInfo = SerializeUtils.ReadBean<ItemInfo>(stream);
	}
	
	/**
	 * 成功0 1 失败
	 */
	public byte ReturnInfo
	{
		set { _returnInfo = value; }
	    get { return _returnInfo; }
	}
	
	/**
	 * 合成0 1分解
	 */
	public byte Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	/**
	 * 返回信息
	 */
	public ItemInfo ItemInfo
	{
		set { _itemInfo = value; }
	    get { return _itemInfo; }
	}
	
	
	public override int GetId() 
	{
		return 110101;
	}
}